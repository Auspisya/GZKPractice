﻿using GBUZhilishnikKuncevo.Classes;
using GBUZhilishnikKuncevo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace GBUZhilishnikKuncevo.Pages
{
    /// <summary>
    /// Логика взаимодействия для AccountingEditPage.xaml
    /// </summary>
    public partial class AccountingEditPage : Page
    {
        int accountingId;

        public AccountingEditPage(Accounting accounting)
        {
            InitializeComponent();

            #region Наполняем элементы управления данными из БД по выбранной записи
            //Наполняем поле выбора из БД
            CmbService.DisplayMemberPath = "TypeOfService.serviceName";
            CmbService.SelectedValuePath = "id";
            CmbService.ItemsSource = DBConnection.DBConnect.Service.ToList();
            CmbService.Text = accounting.Service.TypeOfService.serviceName.ToString();
            //Наполняем поле выбора из БД
            CmbCounterNumber.DisplayMemberPath = "counterNumber";
            CmbCounterNumber.SelectedValuePath = "id";
            CmbCounterNumber.ItemsSource = DBConnection.DBConnect.Counter.ToList();
            CmbCounterNumber.Text = accounting.Counter.counterNumber.ToString();
            //Наполняем поле выбора из БД
            CmbBankBook.DisplayMemberPath = "bankBookNumber";
            CmbBankBook.SelectedValuePath = "id";
            CmbBankBook.ItemsSource = DBConnection.DBConnect.BankBook.ToList();
            CmbBankBook.Text = accounting.BankBook.bankBookNumber.ToString();
            //Наполняем текстовое поле
            TxbCounterReading.Text = accounting.counterReading.ToString();
            TxbUnit.Text = accounting.Service.unit.ToString();
            //Заполняем дата-пикеры готовыми данными из БД
            DPDateOfEnd.Text = accounting.accountingEnd.ToShortDateString();
            DPDateOfStart.Text = accounting.accountingStart.ToShortDateString();
            #endregion
            accountingId = accounting.id;
        }

        /// <summary>
        /// Переадресация фрейма на предыдущую страницу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Navigation.frameNav.GoBack();
        }

       /// <summary>
       /// Вносит изменения в базу данных
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (TxbCounterReading.Text == "" || TxbUnit.Text == "" || DPDateOfEnd.Text == "" || DPDateOfStart.Text == "" ||
                CmbBankBook.Text == "" || CmbCounterNumber.Text == "" || CmbService.Text == "")
            {
                MessageBox.Show("Нужно заполнить все поля!",
                    "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                if (MessageBox.Show("Вы точно хотите внести изменения?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
                {

                }
                else
                {
                    //Подключаемся к БД
                    menshakova_publicUtilitiesEntities context = new menshakova_publicUtilitiesEntities();
                    #region Берем значения из элементов управления и вносим их в базу данных
                    var accounting = context.Accounting.Where(item => item.id == accountingId).FirstOrDefault();
                    accounting.counterReading = double.Parse(TxbCounterReading.Text);
                    accounting.accountingStart = DateTime.Parse(DPDateOfStart.Text);
                    accounting.accountingEnd = DateTime.Parse(DPDateOfEnd.Text);
                    accounting.counterId = (CmbCounterNumber.SelectedItem as Counter).id;
                    accounting.bankBookId = (CmbBankBook.SelectedItem as BankBook).id;
                    accounting.serviceId = (CmbService.SelectedItem as Service).id;

                    var serviceCheck = context.ServiceCheck.Where(item => item.accountingId == accountingId).FirstOrDefault();
                    serviceCheck.totalPayble = Decimal.Parse(TxbCounterReading.Text) * (decimal)accounting.Service.standartTariff;
                    #endregion
                    //Сохраняем данные в БД
                    context.SaveChanges();
                    MessageBox.Show("Данные успешно изменены!",
                            "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    //Возвращаемся обратно
                    Navigation.frameNav.GoBack();
                }
            }
        }

        /// <summary>
        /// Вывод единицы измерения в зависимости от выбранной услуги
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbService_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var unit = (CmbService.SelectedItem as Service).unit.ToString();
            TxbUnit.Text = unit;
        }
        /// <summary>
        /// Разрешение на ввод только цифр и некоторых символов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxbNum_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            string pattern = @"[^0-9+-,.]+";
            if (Regex.IsMatch(e.Text, pattern))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Вывод типа счётчика в зависимости от выбранного номера счётчика
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbCounterNumber_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CmbCounterNumber.SelectedIndex == -1) { TxbCounterType.Text = ""; }
            else
            {
                try
                {
                    var counterType = (CmbCounterNumber.SelectedItem as Counter).TypeOfCounter.counterName;
                    TxbCounterType.Text = counterType.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

using GBUZhilishnikKuncevo.Classes;
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
    /// Логика взаимодействия для AccountingAddPage.xaml
    /// </summary>
    public partial class AccountingAddPage : Page
    {
        public AccountingAddPage()
        {
            InitializeComponent();
            ///Наполняем поле выбора из БД
            CmbService.DisplayMemberPath = "TypeOfService.serviceName";
            CmbService.SelectedValuePath = "id";
            CmbService.ItemsSource = DBConnection.DBConnect.Service.ToList();
            ///Наполняем поле выбора из БД
            CmbCounterNumber.DisplayMemberPath = "counterNumber";
            CmbCounterNumber.SelectedValuePath = "id";
            CmbCounterNumber.ItemsSource = DBConnection.DBConnect.Counter.ToList();
            ///Наполняем поле выбора из БД
            CmbBankBook.DisplayMemberPath = "bankBookNumber";
            CmbBankBook.SelectedValuePath = "id";
            CmbBankBook.ItemsSource = DBConnection.DBConnect.BankBook.ToList();
        }

        /// <summary>
        /// Переадресация на предыдущую страницу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Navigation.frameNav.GoBack();
        }

        /// <summary>
        /// Добавление показаний и формирование чека по услуге в базу данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (TxbCounterReading.Text == "" || DPDateOfEnd.Text == "" || DPDateOfStart.Text == "" || CmbService.Text == "")
            {
                MessageBox.Show("Нужно заполнить все поля!",
                    "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                if (MessageBox.Show("Вы точно хотите добавить показания?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
                {

                }
                else
                {
                    try
                    {
                        var serviceAccountingCheck = decimal.Parse(TxbCounterReading.Text);
                            
                        Accounting accounting = new Accounting()
                        {
                            counterReading = double.Parse(TxbCounterReading.Text),
                            Service = CmbService.SelectedItem as Service,
                            Counter = CmbCounterNumber.SelectedItem as Counter,
                            BankBook = CmbBankBook.SelectedItem as BankBook,
                            accountingStart = DateTime.Parse(DPDateOfStart.Text),
                            accountingEnd = DateTime.Parse(DPDateOfEnd.Text)
                        };

                        ServiceCheck serviceCheck = new ServiceCheck()
                        {
                            accountingId = accounting.id,
                            totalPayble = serviceAccountingCheck * (decimal)accounting.Service.standartTariff,
                        };

                        DBConnection.DBConnect.Accounting.Add(accounting);
                        DBConnection.DBConnect.ServiceCheck.Add(serviceCheck);
                        DBConnection.DBConnect.SaveChanges();
                        MessageBox.Show("Показания успешно добавлены!",
                            "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                        Navigation.frameNav.GoBack();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(),
                            "Критическая ошибка",
                            MessageBoxButton.OK,
                            MessageBoxImage.Warning);
                    }
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
            var unit = (CmbService.SelectedItem as Service).unit;
            TxbUnit.Text = unit.ToString();
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

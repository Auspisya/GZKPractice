using GBUZhilishnikKuncevo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace GBUZhilishnikKuncevo.Pages.MenuPages
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Переход на страницу с квартиросъемщиками
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClientPage_Click(object sender, RoutedEventArgs e)
        {
            Navigation.frameNav.Navigate(new ClientPage());
        }

        /// <summary>
        /// Переход на страницу с счётчиками
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCounterPage_Click(object sender, RoutedEventArgs e)
        {
            Navigation.frameNav.Navigate(new CounterPage());
        }

        private void BtnBankBookPage_Click(object sender, RoutedEventArgs e)
        {
            Navigation.frameNav.Navigate(new BankBookPage());
        }

        private void BtnAccountingPage_Click(object sender, RoutedEventArgs e)
        {
            Navigation.frameNav.Navigate(new AccountingPage());
        }

        private void BtnServiceCheckPage_Click(object sender, RoutedEventArgs e)
        {
            Navigation.frameNav.Navigate(new ServiceCheckPage());
        }

        private void BtnDebtPage_Click(object sender, RoutedEventArgs e)
        {
            Navigation.frameNav.Navigate(new DebtorsPage());
        }
    }
}

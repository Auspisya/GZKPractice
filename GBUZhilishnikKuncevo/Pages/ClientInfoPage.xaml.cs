using GBUZhilishnikKuncevo.Classes;
using GBUZhilishnikKuncevo.Models;
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

namespace GBUZhilishnikKuncevo.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClientInfoPage.xaml
    /// </summary>
    public partial class ClientInfoPage : Page
    {
        public ClientInfoPage(Client client)
        {
            InitializeComponent();

            #region Наполняем текстовые блоки информацией из БД
            if (client.patronymic == "") { TxbFullName.Text = client.surname.ToString() + " " + client.name.ToString(); } 
            else { TxbFullName.Text = client.surname.ToString() + " " + client.name.ToString() + " " + client.patronymic.ToString(); }
            TxbNumPassport.Text = client.Passport.passportNumber.ToString();
            TxbDateOfBirth.Text = client.dateOfBirth.ToShortDateString();
            TxbGender.Text = client.Gender.genderName.ToString();
            TxbPassportSeries.Text = client.Passport.passportSeries.ToString();
            TxbPassportIssuedBy.Text = client.Passport.passportIssuedBy.ToString();
            TxbDateOfIssue.Text = client.Passport.dateOfIssue.ToShortDateString();
            TxbDivisionCode.Text = client.Passport.divisionCode.ToString();
            TxbPlaceOfBirth.Text = client.Passport.placeOfBirth.ToString();
            TxbWhoRegisteredTIN.Text = client.TIN.whoRegistered.ToString();
            TxbTINRegistrationDate.Text = client.TIN.registrationDate.ToShortDateString();
            TxbSNILSRegistrationDate.Text = client.SNILS.registrationDate.ToShortDateString();
            TxbSNILS.Text = client.SNILS.snilsNumber.ToString();
            TxbTIN.Text = client.TIN.tinNumber.ToString();

            var bankBookList = DBConnection.DBConnect.BankBook.ToList();
            var bankBook = bankBookList.Where(item => item.clientId == client.id).ToList();


            CmbBankBook.DisplayMemberPath = "bankBookNumber";
            CmbBankBook.SelectedValuePath = "id";
            CmbBankBook.ItemsSource = bankBook;
            if (client.BankBook.Count != 0) { CmbBankBook.Text = bankBook[0].bankBookNumber.ToString(); } else { CmbBankBook.Text = ""; }  
            #endregion
        }

        /// <summary>
        /// Возвращаемся назад
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Navigation.frameNav.GoBack();
        }
    }
}

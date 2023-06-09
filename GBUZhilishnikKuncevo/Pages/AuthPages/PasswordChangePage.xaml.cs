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

namespace GBUZhilishnikKuncevo.Pages.AuthPages
{
    /// <summary>
    /// Логика взаимодействия для PasswordChangePage.xaml
    /// </summary>
    public partial class PasswordChangePage : Page
    {
        public static int UserId;
        string password;
        public PasswordChangePage()
        {
            InitializeComponent();
        }

        private void PsbPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = (PasswordBox)sender;
            password = PsbPassword.Password;
            PasswordStrength strength = CheckPassword(password);
            switch (strength)
            {
                case PasswordStrength.Terrible:
                    TxbPasswordTip.Text = "Ужасный пароль";
                    TxbPasswordTip.Foreground = new SolidColorBrush(Colors.DarkRed);
                    BorderTip.Background = new SolidColorBrush(Colors.DarkRed);
                    break;
                case PasswordStrength.Weak:
                    TxbPasswordTip.Text = "Слабый пароль";
                    TxbPasswordTip.Foreground = new SolidColorBrush(Colors.Red);
                    BorderTip.Background = new SolidColorBrush(Colors.Red);
                    break;
                case PasswordStrength.Moderate:
                    TxbPasswordTip.Text = "Умеренный пароль";
                    TxbPasswordTip.Foreground = new SolidColorBrush(Colors.Orange);
                    BorderTip.Background = new SolidColorBrush(Colors.Orange);
                    break;
                case PasswordStrength.Good:
                    TxbPasswordTip.Text = "Хороший пароль";
                    TxbPasswordTip.Foreground = new SolidColorBrush(Colors.Yellow);
                    BorderTip.Background = new SolidColorBrush(Colors.Yellow);
                    break;
                case PasswordStrength.Strong:
                    TxbPasswordTip.Text = "Сильный пароль";
                    TxbPasswordTip.Foreground = new SolidColorBrush(Colors.LimeGreen);
                    BorderTip.Background = new SolidColorBrush(Colors.LimeGreen);
                    break;
                case PasswordStrength.Excellent:
                    TxbPasswordTip.Text = "Отличный пароль";
                    TxbPasswordTip.Foreground = new SolidColorBrush(Colors.LightGreen);
                    BorderTip.Background = new SolidColorBrush(Colors.LightGreen);
                    break;
                case PasswordStrength.Remarkable:
                    TxbPasswordTip.Text = "Замечательный пароль";
                    TxbPasswordTip.Foreground = new SolidColorBrush(Colors.Green);
                    BorderTip.Background = new SolidColorBrush(Colors.Green);
                    break;
            }
        }

        private void TxbPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            password = TxbPassword.Text;
        }

        private void CBShowHidePassword_Click(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;
            if (checkBox.IsChecked.Value)
            {
                TxbPassword.Text = PsbPassword.Password;
                TxbPassword.Visibility = Visibility.Visible;
                PsbPassword.Visibility = Visibility.Hidden;
                CBShowHidePassword.ToolTip = "Скрыть";
            }
            else
            {
                PsbPassword.Password = TxbPassword.Text;
                TxbPassword.Visibility = Visibility.Hidden;
                PsbPassword.Visibility = Visibility.Visible;
                CBShowHidePassword.ToolTip = "Показать";
            }
        }

        private enum PasswordStrength
        {
            Terrible,
            Weak,
            Moderate,
            Good,
            Strong,
            Excellent,
            Remarkable
        }

        private PasswordStrength CheckPassword(string password)
        {
            int digitCount = 0;
            int uppercaseCount = 0;
            int lowercaseCount = 0;
            int specialCharCount = 0;
            char prevChar = '\0';
            int consecutiveUppercaseCount = 0;
            PasswordStrength result = PasswordStrength.Weak;


            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    digitCount++;
                }
                else if (char.IsUpper(c))
                {
                    uppercaseCount++;

                    if (prevChar != '\0' && prevChar == c - 1)
                    {
                        consecutiveUppercaseCount++;
                    }
                    else
                    {
                        consecutiveUppercaseCount = 0;
                    }
                }
                else if (char.IsLower(c))
                {
                    lowercaseCount++;
                }
                else
                {
                    specialCharCount++;
                }

                prevChar = c;
            }

            if (digitCount == password.Length)
            {
                result = PasswordStrength.Terrible;
            }
            if (lowercaseCount > 0 && digitCount >= 1 && digitCount <= 2)
            {
                result = PasswordStrength.Weak;
            }
            if (lowercaseCount > 0 && digitCount > 3)
            {
                result = PasswordStrength.Moderate;
            }
            if (uppercaseCount > 0 && lowercaseCount > 0 && digitCount > 3)
            {
                result = PasswordStrength.Good;
            }
            if (uppercaseCount > 0 && lowercaseCount > 0 && digitCount > 3 && specialCharCount >= 1)
            {
                result = PasswordStrength.Strong;
            }
            if (uppercaseCount > 0 && lowercaseCount > 0 && digitCount > 3 && specialCharCount > 3)
            {
                result = PasswordStrength.Excellent;
            }
            if (uppercaseCount >= 4 && lowercaseCount > 0 && digitCount > 3 && specialCharCount > 5 && consecutiveUppercaseCount == 0)
            {
                result = PasswordStrength.Remarkable;
            }
            return result;
        }

        private void BtnChangePassword_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

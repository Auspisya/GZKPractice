using GBUZhilishnikKuncevo.Classes;
using GBUZhilishnikKuncevo.Pages;
using GBUZhilishnikKuncevo.Pages.AuthPages;
using GBUZhilishnikKuncevo.Pages.MenuPages;
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

namespace GBUZhilishnikKuncevo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Navigation.frameNav = MainFrame;
            MainFrame.Navigate(new AuthorizationPage());
            MenuNavigation.frameNav = MenuFrame;
            MenuFrame.Navigate(new MenuAuthPage());
        }
    }
}

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

namespace TRPO_Testirovanie
{
    /// <summary>
    /// Логика взаимодействия для Auth_Register.xaml
    /// </summary>
    public partial class Auth_Register : Page
    {
        MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
        public Auth_Register()
        {
            InitializeComponent();
            

        }

        private void Auth_Click(object sender, RoutedEventArgs e)
        {
            App.auth = new Auth();
            mainWindow.mainFrame.Navigate(App.auth);
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            App.register = new Register();
            mainWindow.mainFrame.Navigate(App.register);
        }
    }
}

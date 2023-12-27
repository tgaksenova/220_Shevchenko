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
using TRPO_220_Testirovanie;

namespace TRPO_Testirovanie
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {
        MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
        public Auth()
        {
            InitializeComponent();

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            App.Auth_Register = new Auth_Register();
            mainWindow.mainFrame.Navigate(App.Auth_Register);
        }

        private void Auth_Click(object sender, RoutedEventArgs e)
        {
            var req = from x in App.users
                      where x.Login == Login.Text
                      select x.Password;

            if (req.Count() > 0 && req.First().ToString()==Password.Password)
            {
                //var role = from z in App.users
                //           where z.Login == Login.Text
                //           select z.Role.RoleName;
                var role = App.users.Where(x => x.Login == Login.Text).Select(x => x.Role.RoleName).ToList();
                App.mainPage = new MainPage(role.First().ToString());
                mainWindow.mainFrame.Navigate(App.mainPage);

            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }


            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
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
using TRPO_220_Testirovanie;

namespace TRPO_Testirovanie
{
    /// <summary>
    /// Логика взаимодействия для Register.xaml
    /// </summary>
    public partial class Register : Page
    {
        MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
        public Register()
        {
            InitializeComponent();
            Role.SelectedIndex = 0;
        }

        private void Auth_Click(object sender, RoutedEventArgs e)
        {
            TestirovanieEntities testirovanie = new TestirovanieEntities(); 
            var logins = from z in App.users
                         where z.Login == Login.Text
                         select z.Login;

            Regex eng = new Regex(@"^[A-Za-z\d_-]+$");

            

            if (Login.Text != "")
            {
                if (logins.Count() == 0)
                {
                    if (Password.Password.Length < 6 | Password.Password.Contains(" ") | !(eng.Match(Password.Password).Success) | !(Regex.Match(Password.Password, @"\d").Success))
                    {
                        MessageBox.Show("Пароль должен содержать 6 или более символов\nДолжен иметь хотя бы одну цифру\nДолжен содержать английские символы");
                    }
                    else
                    {

                        if (Password.Password == AuthPass.Password)
                        {
                            int role = 0;
                            if (Role.SelectedIndex == 0)
                            {
                                role = 1;
                            }
                            else if (Role.SelectedIndex == 1)
                            {
                                role = 2;
                            }

                            Users user = new Users
                            {
                                Login = Login.Text,
                                Password = Password.Password,
                                RoleID = role,
                                Role=App.role.Where(x=>x.ID==role).First()
                            };

                            //App.users.Add(user);
                            testirovanie.Users.Add(user);
                            testirovanie.SaveChanges();
                            App.users = testirovanie.Users.ToList();
                            

                            App.auth = new Auth();
                            mainWindow.mainFrame.Navigate(App.auth);
                        }
                        else
                        {
                            MessageBox.Show("Пароли не совпадают");
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("Такой логин уже существует");
                    Password.Clear();
                }
            }
            else
            {
                MessageBox.Show("Введите логин");
            }
            testirovanie.Dispose();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            App.Auth_Register = new Auth_Register();
            mainWindow.mainFrame.Navigate(App.Auth_Register);
        }
    }
}

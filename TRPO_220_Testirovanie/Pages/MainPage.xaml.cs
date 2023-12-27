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
using TRPO_Testirovanie;

namespace TRPO_220_Testirovanie
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        string Role = "";
        int table;
        public MainPage(string role)
        {
            InitializeComponent();
            Role = role;
            if (Role == "Студент")
            {
                Addbut.IsEnabled = false;
                Questbut.IsEnabled = false;
                Studbut.IsEnabled = false;
            }
            else
            {
                Addbut.IsEnabled = true;
                Questbut.IsEnabled = true;
                Studbut.IsEnabled = true;
            }
        }

        private void Questions_Click(object sender, RoutedEventArgs e)
        {
            App.QuestionsView = new QuestionsView();
            dbFrame.Navigate(App.QuestionsView);
            table = 1;
        }

        private void Tests_Click(object sender, RoutedEventArgs e)
        {
            App.TestsView = new TestsView();
            dbFrame.Navigate(App.TestsView);
            table = 2;
        }

        private void Students_Click(object sender, RoutedEventArgs e)
        {
            App.studentsView = new StudentsView();
            dbFrame.Navigate(App.studentsView);
            table = 3;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            App.Add_Edit = new Add_Edit();
            dbFrame.Navigate(App.Add_Edit);
        }


        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (this.dbFrame.NavigationService.Content.GetType().ToString().Replace("TRPO_220_Testirovanie.", "") == "StudentsView")
                {
                    //try {
                        App.studentsView.students.ItemsSource = App.StudenInformationList.Where(x => x.FirstName.ToLower().Contains(Search.Text.ToLower()) || x.SecondName.ToLower().Contains(Search.Text.ToLower()) || x.Patronymic.ToLower().Contains(Search.Text.ToLower())).Where(x => x.Group.GroupNumber ==(App.studentsView.Filter.SelectedValue!=null?App.studentsView.Filter.SelectedValue:"").ToString()).ToList();

                    //}
                    //catch (System.InvalidCastException ex) 
                    //{
                    //    App.studentsView.students.ItemsSource = App.StudenInformationList.Where(x => x.FirstName.ToLower().Contains(Search.Text.ToLower()) || x.SecondName.ToLower().Contains(Search.Text.ToLower()) || x.Patronymic.ToLower().Contains(Search.Text.ToLower())).Cast<List<StudenInformation>>().ToList();
                    //    throw ex;

                    //}
                }
            }
            catch (System.NullReferenceException ex) {
                throw ex;
            }
        }
    }
}

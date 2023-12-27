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
    /// Логика взаимодействия для Add_Edit.xaml
    /// </summary>
    public partial class Add_Edit : Page
    {
        int studusId;
        bool isAddOrEdit = false;
        public Add_Edit(int studentID)
        {
            InitializeComponent();
            List<Group> groups = App.groups;
            groupChoise.ItemsSource = groups;

            StudenInformation studen = App.StudenInformationList.Where(x=>x.StudentID==studentID).First();
            FirstName.Text = studen.FirstName;
            StudID.Text = studen.StudentID.ToString();
            SecondName.Text = studen.SecondName;
            Patronymic.Text = studen.Patronymic;
            isAddOrEdit = true;
            studusId = studentID;
            groupChoise.SelectedIndex = groups.IndexOf(groups.Where(x => x.ID == studen.GroupID).First());
            //MessageBox.Show(groupChoise.Items.IndexOf(App.groups.Where(x => x.ID == studen.GroupID).First()).ToString());
        }
        public Add_Edit()
        {
            InitializeComponent();
            List<Group> groups = App.groups;
            groupChoise.ItemsSource = groups;
            groupChoise.SelectedIndex = 0;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            TestirovanieEntities testirovanie = new TestirovanieEntities();

            if (FirstName.Text == "" | StudID.Text == "" | SecondName.Text == "" | Patronymic.Text == "")
            {
                MessageBox.Show("Введите данные");
            }
            else
            {
                if (isAddOrEdit) {
                    var studen =testirovanie.StudenInformation.Single(x=>x.StudentID==studusId);
                    var req = from x in App.groups
                              where x.GroupNumber == groupChoise.SelectedValue.ToString()
                              select x.ID;
                    studen.StudentID = Convert.ToInt32(StudID.Text);
                    studen.GroupID = Convert.ToInt32(req.First());
                    studen.Group = testirovanie.Group.Single(x => x.GroupNumber==groupChoise.SelectedValue.ToString());
                    studen.FirstName = FirstName.Text;
                    studen.SecondName = SecondName.Text;
                    studen.Patronymic = Patronymic.Text;
                    foreach (var item in testirovanie.StudenInformation)
                    {
                        var a = item.GroupID;
                        item.Group = testirovanie.Group.Single(x=>x.ID==a);
                    }
                    testirovanie.SaveChanges();
                    App.StudenInformationList = testirovanie.StudenInformation.ToList();
                    testirovanie.Dispose();
                }
                else
                {
                    var req = from x in App.groups
                              where x.GroupNumber == groupChoise.SelectedValue.ToString()
                              select x.ID;
                    StudenInformation student = new StudenInformation
                    {
                        StudentID = Convert.ToInt32(StudID.Text),
                        GroupID = Convert.ToInt32(req.First()),
                        FirstName = FirstName.Text,
                        SecondName = SecondName.Text,
                        Patronymic = Patronymic.Text
                    };
                    
                    testirovanie.StudenInformation.Add(student);
                    testirovanie.SaveChanges();
                    foreach (var item in testirovanie.StudenInformation)
                    {
                        var a = item.GroupID;
                        item.Group = testirovanie.Group.Single(x => x.ID == a);
                    }
                    testirovanie.SaveChanges();
                    App.StudenInformationList = testirovanie.StudenInformation.ToList();
                    testirovanie.Dispose();
                }
                //App.mainPage = new MainPage("Преподаватель");
                App.studentsView = new StudentsView();
                App.mainPage.dbFrame.Navigate(App.studentsView);
            }
            
        }
    }
}

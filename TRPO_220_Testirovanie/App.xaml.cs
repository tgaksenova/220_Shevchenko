using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TRPO_220_Testirovanie;
using TRPO_Testirovanie;

namespace TRPO_Testirovanie
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    

    public partial class App : Application
    {
        
        public static Auth_Register Auth_Register;
        public static Register register;
        public static Auth auth;
        public static MainPage mainPage;
        public static TestsView TestsView;
        public static QuestionsView QuestionsView;
        public static StudentsView studentsView;
        public static Add_Edit Add_Edit;

        public static List<TestReport> TestsList;
        public static List<StudenInformation> StudenInformationList;
        public static List<TestQInformation> TestQInformationList;
        public static List<Group> groups;
        public static List<QuestType> questTypes;
        public static List<Users> users;
        public static List<Role> role;

        protected override void OnStartup(StartupEventArgs e)
        {
            Application.Current.Resources = new ResourceDictionary() { Source = new Uri("pack://application:,,,/Style.xaml") };

            TestirovanieEntities testirovanie = new TestirovanieEntities();
            TestsList = testirovanie.TestReport.ToList();
            StudenInformationList = testirovanie.StudenInformation.ToList();
            TestQInformationList = testirovanie.TestQInformation.ToList();
            groups = testirovanie.Group.ToList();
            questTypes = testirovanie.QuestType.ToList();
            users = testirovanie.Users.ToList();
            role = testirovanie.Role.ToList();

            //testirovanie.Dispose();
        }
    }

    
}

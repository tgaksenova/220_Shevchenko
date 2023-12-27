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
    /// Логика взаимодействия для TestsView.xaml
    /// </summary>
    public partial class TestsView : Page
    {
        public TestsView()
        {
            InitializeComponent();
            //Testirovanie testirovanie = new Testirovanie();
            var req = from x in App.TestsList
                      select new { x.TestDate, x.StudentID, x.SpentTime, x.CorrectAmount, x.QuestionsAmount, x.StudentMark };
            tests.ItemsSource = req.ToList();
        }
    }
}

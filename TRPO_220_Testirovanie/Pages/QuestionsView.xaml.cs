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
    /// Логика взаимодействия для QuestionsView.xaml
    /// </summary>
    public partial class QuestionsView : Page
    {
        public QuestionsView()
        {
            InitializeComponent();
            var req = from s in App.TestQInformationList
                      select new { s.QuestType.Type, s.Question, s.Variant1, s.Variant2, s.Variant3, s.Variant4, s.CorrAnswer };
            questions.ItemsSource = req.ToList();
        }
    }
}

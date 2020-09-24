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

namespace IvanArsua.DateCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            DateTime birthday = DateTime.Parse(dtBirthday.Text);
            DateTime now = DateTime.Now;
            string bday = birthday.Day + "/" + birthday.Month + "/2021";

            DateTime nextBirthday2021 = DateTime.Parse(bday);
            MessageBox.Show(bday);

            double days = (nextBirthday2021 - now).TotalDays;
            MessageBox.Show(days.ToString());
        }
    }
}

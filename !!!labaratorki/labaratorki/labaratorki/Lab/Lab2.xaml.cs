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

namespace labaratorki.Lab
{
    /// <summary>
    /// Логика взаимодействия для Lab2.xaml
    /// </summary>
    public partial class Lab2 : Page
    {
        public Lab2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TB_G.Text = "Результаты работы программы ст.Щеглова Виктора" + Environment.NewLine;
            double x = Convert.ToDouble(TB_X.Text);
            double b = Convert.ToDouble(TB_B.Text);
            double s;
            double f = Math.Pow(Math.E, x);
            if (x * b > 1 && x * b < 10)
            {
                s = Math.Pow(Math.E, f);
            }
            else if (x * b > 12 && x * b < 40)
            {
                s = Math.Sqrt(Math.Abs(f + 4 * b));
            }
            else
            {
                s = b * Math.Pow(f, 2);
            }
            TB_G.Text += "x=" + x.ToString() + Environment.NewLine;
            TB_G.Text += "b=" + b.ToString() + Environment.NewLine;
            TB_G.Text += "s=" + s.ToString() + Environment.NewLine;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TB_X.Clear();
            TB_B.Clear();
            TB_G.Clear();
        }
    }
}

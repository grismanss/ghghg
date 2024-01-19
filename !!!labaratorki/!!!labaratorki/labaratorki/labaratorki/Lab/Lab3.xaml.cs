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
    /// Логика взаимодействия для Lab3.xaml
    /// </summary>
    public partial class Lab3 : Page
    {
        public Lab3()
        {
            InitializeComponent();
        }

        private void Vivod_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void vuvod_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Vivod_Click_1(object sender, RoutedEventArgs e)
        {
            double x0, xk, dx, b;
            if (!double.TryParse(TextBox_X0.Text, out x0) || !double.TryParse(TextBox_xk.Text, out xk) || !double.TryParse(TextBox_dx.Text, out dx) || !double.TryParse(TextBox_B.Text, out b))
            {
                MessageBox.Show("Введите корректное число!");
                return;
            }
            x0 = Convert.ToDouble(TextBox_X0.Text);
            xk = Convert.ToDouble(TextBox_xk.Text);
            dx = Convert.ToDouble(TextBox_dx.Text);
            b = Convert.ToDouble(TextBox_B.Text);
            int count = 0;
            while (x0 <= xk)
            {
                double y = 9 * (x0 + 15 * Math.Sqrt(Math.Pow(x0, 3) + Math.Pow(b, 3)));
                vuvod.Text += "x = " + x0 + "; y = " + Math.Round(y, 4) + Environment.NewLine;
                x0 += dx;
                count++;
            }
            vuvod.Text += "Количество итерации - " + count;
        }
    }
}

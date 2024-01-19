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
    /// Логика взаимодействия для Lab1.xaml
    /// </summary>
    public partial class Lab1 : Page
    {
        public Lab1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double y, z, x;
            TB_G.Text += Environment.NewLine + "Лаб.раб.N1. Щеглов Виктор";
            x = double.Parse(TB_X.Text);
            TB_G.Text += Environment.NewLine + "X = " + x.ToString();
            y = double.Parse(TB_Y.Text);
            TB_G.Text += Environment.NewLine + "Y = " + y.ToString();
            z = double.Parse(TB_Z.Text);
            TB_G.Text += Environment.NewLine + "z = " + z.ToString();



            double g = 5 * Math.Atan(x) - ((1.0 / 4) * (Math.Acos(x)) * ((x + 3 * Math.Abs(x - y) + Math.Pow(x, 2)) / (Math.Abs(x - y) * z + Math.Pow(x, 2))));
            TB_G.Text += Environment.NewLine + "G = " + g.ToString();
        }
    }
}

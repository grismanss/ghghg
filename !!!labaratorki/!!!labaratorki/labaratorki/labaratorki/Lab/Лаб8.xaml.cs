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
    /// Логика взаимодействия для Лаб8.xaml
    /// </summary>
    public partial class Лаб8 : Page
    {
        public Лаб8()
        {
            InitializeComponent();
        }

        private void BT_Click(object sender, RoutedEventArgs e)
        {
            Polyline polyline = new Polyline();
            polyline.Stroke = System.Windows.Media.Brushes.LightSteelBlue;
            PointCollection maspoint = new PointCollection();
            
           
            double x0 = Convert.ToDouble(TBx0.Text);
            double xk = Convert.ToDouble(TBxk.Text);
            double dx = Convert.ToDouble(TBdx.Text);
            double b = Convert.ToDouble(TBb.Text);
            for (double i=x0; i<=xk; i=i+dx)
            {
                double y = 9*(i+15*Math.Sqrt(Math.Pow(i,3)+Math.Pow(b,3)));
                Point p = new Point(i*(10),y/2);
                maspoint.Add(p);
            }
            polyline.Points = maspoint;
           
            mypoly.Points= maspoint;

        }
    }
}

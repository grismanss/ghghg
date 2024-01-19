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
    /// Логика взаимодействия для Lab7.xaml
    /// </summary>
    public partial class Lab7 : Page
    {
        int x = 400;
        public Lab7()
        {
            InitializeComponent();
        }

        private void BT_Click(object sender, RoutedEventArgs e)
        { 
            x -= 50;
            BitmapImage OBs = new BitmapImage(new Uri("123.jpg", UriKind.Relative));
            ImageBrush myImageBrush = new ImageBrush(OBs);

           // Canvas myCanvas = new Canvas();
           // myCanvas.Width = 800;
           // myCanvas.Height = 600;
           // myCanvas.Background = myImageBrush;
            Ellipse ellipse = new Ellipse();
            ellipse.Width = 200;
            ellipse.Height = 200;
            ellipse.Fill = Brushes.Red;
            ellipse.Margin=new Thickness(0,200,0,0);
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 200;
            rectangle.Height = 30;
            rectangle.Fill = Brushes.Black;
          //  rectangle.Margin = new Thickness(0,400,0,0);
          //  mainPanel.Children.Add(myCanvas);
            mainPanel.Children.Add(ellipse);
            mainPanel.Children.Add(rectangle);
           
            mainPanel.InvalidateVisual();

            //прдумать проресовку объуктов и данамическую движение объекта

        }
    }
}

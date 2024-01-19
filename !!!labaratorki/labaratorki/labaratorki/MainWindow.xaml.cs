using labaratorki.Lab;
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
using labaratorki.Lab;

namespace labaratorki
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Lab3_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Lab3());
        }

        private void Lab1_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Lab1());
        }

        private void Lab2_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Lab2());
        }

        private void Lav4_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Lav4());
        }

        private void Lab5_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Lab5());
        }

        private void Lab6_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Lab6());
        }
    }
}

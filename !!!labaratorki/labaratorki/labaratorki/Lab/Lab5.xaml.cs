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
    /// Логика взаимодействия для Lab5.xaml
    /// </summary>
    public partial class Lab5 : Page
    {
        private int[] iskhodnyMas; //объявление массива  
        public Lab5()
        {
            InitializeComponent();
        }

        
        private void Btn_iskhodnyMas_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            iskhodnyMas = new int[30];
            for (int i = 0; i < 30; i++)
            {
                iskhodnyMas[i] = rnd.Next(1, 150);
                TextBox_iskhodnyMas.Text += "Massiv[" + Convert.ToString(i + 1) + "] = " + iskhodnyMas[i] + Environment.NewLine;
            }
        }
        private void Btn_izmenennyMas_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            int sum = 0;
            for (int i = 0; i < 30; i++)
            {
                if (iskhodnyMas[i] % 5 == 0 && iskhodnyMas[i] % 7 != 0)
                {
                    count++;
                    sum += iskhodnyMas[i];
                    TextBox_izmenennyMas.Text += "Massiv[" + Convert.ToString(i + 1) + "] = " + iskhodnyMas[i] + Environment.NewLine;
                    
                }
            }
            TextBox_izmenennyMas.Text += "Кол-во элементов = " + count + Environment.NewLine;
            TextBox_izmenennyMas.Text += "Сумма элементов = " + sum;
        }

       
    }
}
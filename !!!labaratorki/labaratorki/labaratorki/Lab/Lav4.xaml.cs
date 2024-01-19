using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace labaratorki.Lab
{
    /// <summary>
    /// Логика взаимодействия для Lav4.xaml
    /// </summary>
    public partial class Lav4 : Page
    {
        int countBtm = 0;
        int countlabel = 0;
        int countTB = 0;
        public Lav4()
        {
            InitializeComponent();
        }

        private void Button_Vivod_Click(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(Count_TB.Text); 
            for (int i = 0; i < n; i++)
            {
                var Btn = new Button();//создание кнопки
                Btn.Width = 100;
                Btn.Height = 35;   
                ConfigsBox.Children.Add(Btn);//в steck panel добавляется элемент созданый выше в цикле,то есть мы заполняем стек понель контентом,
                                             //чилдрен контейнер в который добавляются эелементы управления (кнопки,метки)
            }
            countBtm += n;
            label_2.Content = "Колисество кнопок:" + countBtm.ToString(); // выводит количество кнопок
            



        }

        private void label_1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int n = Convert.ToInt32(Count_TB.Text);
            for (int i = 0; i < n; i++)
            {
                var label = new Label(); //создание метки
                label.Width = 100;
                label.Height = 35;
                label.Content = i.ToString();//порядковый номер кнопки
                ConfigsBox.Children.Add(label);//в steck panel добавляется элемент созданый выше в цикле,то есть мы заполняем стек понель контентом,
                                               //чилдрен контейнер в который добавляются эелементы управления (кнопки,метки)
            }
            countlabel += n;
            label_3.Content = "Колисество меток:" + countlabel.ToString();
        }

        

        private void TextBox_1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int n = Convert.ToInt32(Count_TB.Text);
            for (int i = 0; i < n; i++)
            {
                var tb = new TextBox();
                tb.Width = 100;
                tb.Height = 35;
                tb.Text = i.ToString();
                ConfigsBox.Children.Add(tb);
            }
            countTB += n;
            label_4.Content = "Колисество текстовых блоков:" + countTB .ToString();
        }
    }
}

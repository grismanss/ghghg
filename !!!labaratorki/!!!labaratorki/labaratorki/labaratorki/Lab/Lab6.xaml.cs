using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для Lab6.xaml
    /// </summary>
    public partial class Lab6 : Page
    {
        int[,] matr;
        int n;
        public Lab6()
        {
            InitializeComponent();
        }

       
        //мы создаем дата тейбл в нем делаем колонки потом создаем строки и заполняем их из нашего массива 
        private void Btn_iskhodnyMas_Click(object sender, RoutedEventArgs e)
        {
            n =Convert.ToInt32(TB.Text);
            matr=new int[n,n];
            Random random = new Random();//создаем класс рандом в котором перебераем числа от -100 до 100
            for (int i = 0; i < n;i++)
            {
                for(int j = 0; j<n;j++)
                {
                    matr[i,j] = random.Next(-100,100);
                }
            }
            DataTable dt = new DataTable();//Источник данных для дата грида
           
            for (int i = 0; i < n; i++)
            {
                dt.Columns.Add(i.ToString(), typeof(double));
            }

            for (int row = 0; row < n; row++)
            {
                DataRow dr = dt.NewRow();
                for (int col = 0; col < n; col++)
                {
                    dr[col] = matr[row, col];
                }
                dt.Rows.Add(dr);
            }

            DG1.ItemsSource = dt.DefaultView;
        }

        private void Btn_izmenennyMas_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < n; i++) 

            {
                int max = matr[i,0];
                for (int j = 0; j < n; j++)
                {
                    if (matr[i,j] > max)
                    {
                        max = matr[i,j];
                    }
                }
                matr[i,i] = max;
            }
            DataTable dt = new DataTable();
           
            for (int i = 0; i < n; i++)
            {
                dt.Columns.Add(i.ToString(), typeof(double));
            }

            for (int row = 0; row < n; row++)
            {
                DataRow dr = dt.NewRow();
                for (int col = 0; col < n; col++)
                {
                    dr[col] = matr[row, col];
                }
                dt.Rows.Add(dr);
            }

            DG2.ItemsSource = dt.DefaultView;
        }
    }
}

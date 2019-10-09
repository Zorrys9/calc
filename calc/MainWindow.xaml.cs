using System;
using System.Collections;
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

namespace calc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList ResultList = new ArrayList();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += 1;
            ResultList.Add(1);
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += 2;
            ResultList.Add(2);
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += 3;
            ResultList.Add(3);
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += 4;
            ResultList.Add(4);
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += 5;
            ResultList.Add(5);
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += 6;
            ResultList.Add(6);
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += 7;
            ResultList.Add(7);
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += 8;
            ResultList.Add(8);
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += 9;
            ResultList.Add(9);
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += 0;
            ResultList.Add(0);
        }

        private void Equally_Click(object sender, RoutedEventArgs e)
        {
            string Number ="";
            double Result = 0;
            int NumInt;
            double NumDouble;
            foreach(var Item in ResultList)
            {
                if (Item.GetType().Name.ToString() == "String")
                {
                    try
                    {
                        NumDouble = double.Parse(Number);
                        Result += NumDouble;
                    }
                    catch
                    {
                        NumInt= int.Parse(Number);
                        Result += NumInt ;
                    }
     
                    

                    Number = "";
                }
                else
                {
                    Number += Item;
                }
            }
            MessageBox.Show(Result.ToString());
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += "+";
            ResultList.Add("+");
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += "-";
            ResultList.Add("-");
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += "*";
            ResultList.Add("*");
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += "/";
            ResultList.Add("/");
        }

        private void AllClear_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text = "";
            ResultList.Clear();
        }

        private void Point_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += ".";
            ResultList.Add(".");
        }
    }
}

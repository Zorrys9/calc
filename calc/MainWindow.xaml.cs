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
        double Result = 0;
        char sym = '+';

        //public void counting()
        //{
        //    foreach(var Item in CalcBox.Text)
        //    {
        //        if(Item == '+' || Item == '-' || Item == '*' || Item == '/' || Item == '=')
        //        {

        //        }
        //    }
        //}

        public void Val()
        {
            string res = "";
            double rs = 0;
            foreach (var itm in ResultList)
            {
                res += itm.ToString();
            }
            try { rs = double.Parse(res); } catch { rs = 0; }
            switch (sym)
            {
                case '+':
                    Result += rs;
                    break;
                case '-':
                    Result -= rs;
                    break;
                case '*':
                    Result *= rs;
                    break;
                case '/':
                    Result /= rs;
                    break;
            }
            sym = '+';
            ResultList.Clear();
        }

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
            Val();
            MessageBox.Show(Result.ToString());
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += "+";
          Val();
            sym = '+';

        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += "-";
        Val();
            sym = '-';

        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += "*";
         Val();
            sym = '*';

        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += "/";
           Val();
            sym = '/';

        }

        private void AllClear_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text = "";
            ResultList.Clear();
            Result = 0;
        }

        private void Point_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += ".";
            ResultList.Add(",");
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
   //         if(e.Key.ToString() == "0") { MessageBox.Show(e.Key.ToString()); }
        }
    }
}

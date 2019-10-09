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

namespace calc
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

        private void One_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += 1;
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += 2;
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += 3;
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += 4;
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += 5;
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += 6;
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += 7;
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += 8;
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += 9;
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += 0;
        }

        private void Equally_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += "+";
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += "-";
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += "*";
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text += "/";
        }

        private void AllClear_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text = "";
        }
    }
}

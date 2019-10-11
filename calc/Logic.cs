using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace calc
{
    class Logic
    {

        public static double Counting(TextBox CalcBox)
        {
            ArrayList ResultList = new ArrayList();
            double Result = 0;
            string number;
            ResultList.Clear();
            foreach (var item in CalcBox.Text)
            {
                ResultList.Add(item);
            }
            ResultList.Add('=');
            char FirstElement = '+';
            char TwoElement = '+';
            int i = 0;
            for (int k = 0; k < ResultList.Count; k++)
            {
                char Item = char.Parse(ResultList[k].ToString());

                if (Item == '+' || Item == '-' || Item == '*' || Item == '/' || Item == '=')
                {

                    TwoElement = FirstElement;
                    FirstElement = Item;
                    number = "";

                    for (int l = i; l < k; l++)
                    {
                        number += ResultList[l].ToString();
                    }
                    switch (TwoElement)
                    {
                        case '+':
                            Result += double.Parse(number);
                            break;
                        case '-':
                            Result -= double.Parse(number);
                            break;
                        case '/':
                            if (double.Parse(number) == 0)
                            {
                                MessageBox.Show("Деление на ноль невозможно!");
                            }
                            else
                            {
                                Result /= double.Parse(number);
                            }
                            break;
                        case '*':
                            Result *= double.Parse(number);
                            break;
                    }
                    i = k + 1;
                }
            }
            return Result;
        }

    }
}

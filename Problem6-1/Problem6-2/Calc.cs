using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6_2
{
     class Calc
    {
        public double Add(double num1, double num2) // 2つの数値の+
        {
            return num1 + num2;
        }

        public double Sub(double num1, double num2) // 2つの数値の-
        {
            return num1 - num2;
        }      
        public double Mul(double num1, double num2) // 2つの数値の＊
        {
            return num1 * num2;
        }
        public double Div(double num1, double num2) // 2つの数値の/
        {
            return num1 / num2;
        }
    }
}

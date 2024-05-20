using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx301
{
    class Calculator
    {
        //  一つ目の数値
        protected int num1;
        //  二つ目の数値
        protected int num2;
        //  num1のプロパティ
        public int Num1
        {
            set { num1 = value; }
            get { return num1; }
        }
        //  num2のプロパティ
        public int Num2
        {
            set { num2 = value; }
            get { return num2; }
        }
        //  足し算
        public void add()
        {
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
        }
        //  引き算
        public void sub()
        {
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
        }
    }
}
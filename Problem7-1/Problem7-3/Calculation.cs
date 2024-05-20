using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7_3
{
    
   
     class Calculation
    {
        private  int number1; //privateで隠す
        private  int number2; //privateで隠す
        public int Number1
        {
            get { return number1; } 
            set { number1 = value; }
        }
        public int Number2
        {
            get { return number2; } 
            set { number2 = value; }
        }
        public int Add()
        {
            return number1 + number2;  //和の計算
        }
        public int Sub()
        {
            return number1 - number2;  //差の計算
        }

    }
   
}

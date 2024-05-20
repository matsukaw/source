using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7_2
{
    class TwoStrings
    {
        private string string1;  //  一つ目の文字列
       
        private string string2;  //  二つ目の文字列

        public string String1 { get; set; }
        public string String2 { get; set; }

        public string GetConnectedString()  //２つを繋げる
        {
            return String1 + String2;
        }


    }
}
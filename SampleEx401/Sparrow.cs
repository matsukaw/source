using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx401
{
    //  すずめクラス
    class Sparrow
    {
        private String name = "すずめ";
        //  カラスがなく
        public void Sing()
        {
            Console.WriteLine("チュンチュン");
        }
        // 名前を取得
        public String Name
        {
            get { return name; }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx303
{
    //  親クラス
    class Parent
    {
        //変更前のコード：public void Foo()
        public  virtual void Foo()
        {
            Console.WriteLine("親クラスのFoo()メソッド");
        }
    }
}
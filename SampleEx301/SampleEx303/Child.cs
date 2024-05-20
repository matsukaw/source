using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx303
{
    //  子クラス
    class Child : Parent
    {
        //変更前のコード： public void Foo() 
        public override void Foo()
        {
            Console.WriteLine("子クラスのFoo()メソッド");
        }
    }
}
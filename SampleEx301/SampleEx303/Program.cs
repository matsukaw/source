using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx303
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Parentクラスのインスタンス生成
            Parent p = new Parent();
            //  Childクラスのインスタンス生成
            Parent c = new Child();
            //  それぞれのクラスのfoo、barメソッドを実行
            p.Foo();
            c.Foo();
        }
    }
}
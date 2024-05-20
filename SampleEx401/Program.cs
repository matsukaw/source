using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx401
{
    class Program
    {
        static void Main(string[] args)
        {
            Crow c = new Crow();          //  カラスクラス
            Sparrow s = new Sparrow();    //  すずめクラス
            //  カラスがなく
            Console.Write(c.Name + " : ");
            c.Sing();
            //  雀がなく
            Console.Write(s.Name + " : ");
            s.Sing();
        }
    }
}
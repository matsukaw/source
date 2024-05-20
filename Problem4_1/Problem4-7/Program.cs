using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        // aの初期値を2に定義し、2ずつ増加させ8になるまでループ
        for (int a = 2; a <= 8; a += 2)
        {
            Console.WriteLine("a = " + a);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int a = 2; // 初期値を定義

        while (a <= 8) // aが8以下の間ループ
        {
            Console.WriteLine("a = " + a);
            a += 2; // aを2増加
        }
    }
}

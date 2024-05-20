using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 9; i++)
        {
            for (int a = 1; a <= 9; a++)
            {
                Console.Write($"{a}*{i}={i * a} ");

                // 段ごとに改行する
                if (a == 9)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}

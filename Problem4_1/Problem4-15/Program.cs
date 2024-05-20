using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++)　//100までループする
        {
            Console.Write(i + " ");　//値が分かり易いように空白をいれておく


            // 10で割り切れたら改行する
            if (i % 10 == 0)
            {
                Console.WriteLine();
            }
        }
    }
}

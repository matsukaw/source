using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("50までの整数値を入力してください：");
            int num = int.Parse(Console.ReadLine());　//入力した整数値を代入するnumを定義。

            if (num % 2 == 0 && num % 3 == 0) //＊公倍数をどう記載したらいいのか少し悩み、解説の図を確認した。
            {
                Console.WriteLine("この値は2と3の公倍数です。");
            }
            else if (num % 2 == 0)
            {
                Console.WriteLine("この値は2の倍数です。");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("この値は3の倍数です。");
            }
            else
            {
                Console.WriteLine("この値は2の倍数でも、3の倍数でもありません。");
            }
        }
    }
}
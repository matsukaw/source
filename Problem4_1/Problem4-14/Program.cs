using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int randomNumber = rand.Next(1, 11); // 範囲1から10までの乱数
        Console.WriteLine($"数値：{randomNumber}");

        // 偶数なら★を、奇数なら☆を表示する
        for (int i = 0; i < randomNumber; i++)
        {
            if (randomNumber % 2 == 0)
            {
                Console.Write("★");
            }
            else
            {
                Console.Write("☆");
            }
        }
        Console.WriteLine();
    }
}

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
        int maxNumber = int.MinValue; // 最大値を初期化
        int minNumber = int.MaxValue; // 最小値を初期化

        for (int i = 0; i < 5; i++)
        {
            int randomNumber = rand.Next(1, 101); // 1から100までの乱数を生成
            Console.WriteLine(randomNumber);

            // 最大値を更新
            if (randomNumber > maxNumber)
            {
                maxNumber = randomNumber;
            }

            // 最小値を更新
            if (randomNumber < minNumber)
            {
                minNumber = randomNumber;
            }
        }

        Console.WriteLine($"最大値：{maxNumber}");
        Console.WriteLine($"最小値：{minNumber}");
    }
}

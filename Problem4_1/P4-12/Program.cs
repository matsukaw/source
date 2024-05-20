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
        int evenCount = 0; // 偶数の数をカウント
        int oddCount = 0;  // 奇数の数をカウント

        for (int i = 0; i < 5; i++)
        {
            int randomNumber = rand.Next(1, 101); // 1から100までの乱数を生成
            Console.WriteLine(randomNumber);

            // 偶数か奇数か判定、対応する変数にカウント
            if (randomNumber % 2 == 0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }
        }

        Console.WriteLine($"偶数の数：{evenCount}");
        Console.WriteLine($"奇数の数：{oddCount}");
    }
}

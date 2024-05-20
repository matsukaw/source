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

        while (true)
        {
            int randomNumber = rand.Next(1, 101); // 1から100までの乱数を生成
            Console.WriteLine(randomNumber);

            if (randomNumber % 10 == 0) // 10の倍数かをチェック
            {
                Console.WriteLine("終了します");
                break; // ループから抜ける
            }
        }
    }
}

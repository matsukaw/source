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

        for (int i = 0; i < 5; i++)　//ループを5回繰り返す
        {
            int randomNumber = rand.Next(1, 101); // 1から100までの乱数を生成
            Console.WriteLine(randomNumber);
        }
    }
}

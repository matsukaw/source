using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {  
        int y = 10;  // 配列指定

        Random rand = new Random();
        int[] array = new int[y];

        int even = 0;
        int odd = 0;
        Console.Write("配列:");
        for (int a = 0; a < y; a++)
        {
            array[a] = rand.Next(1, 101); // 1から100までの乱数
            Console.Write($"{array[a]} ");
            if (array[a] % 2 == 0)
            {
                even++;
            }
            else
            {
                odd++;
            }
        }
        Console.Write("\n奇数:");
        foreach (var num in array) //判別
        {
            if (num % 2 != 0)
            {
                Console.Write($"{num} ");
            }
        }
        Console.Write("\n偶数:");
        foreach (var num in array)
        {
            if (num % 2 == 0)
            {
                Console.Write($"{num} ");
            }
        }
    }
}

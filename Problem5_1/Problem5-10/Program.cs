using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // 長さ7の整数型の配列を生成
        int[] box = new int[7];

        // 1から10までの乱数を各要素に代入
        Random rand = new Random();
        for (int a = 0; a < box.Length; a++)
        {
            box[a] = rand.Next(1, 11); // 1から10までの乱数を生成
        }

        // 乱数で生成された値を表示
        foreach (int num in box)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // それぞれの数に対応する*を表示
        foreach (int num in box)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

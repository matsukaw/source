using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        
        int[] box = new int[5];//配列作成
        Random rand = new Random();
        for (int a = 0; a < box.Length; a++)
        {
            box[a] = rand.Next(1, 101); // 1から100までの乱数
        }
        foreach (int num in box)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // 0以上60未満の数値を表示
        Console.Write("0以上60未満：");
        foreach (int num in box)
        {
            if (num >= 0 && num < 60)
            {
                Console.Write(num + " ");
            }
        }
        Console.WriteLine();

        // 60以上80未満の数値を表示
        Console.Write("60以上80未満：");
        foreach (int num in box)
        {
            if (num >= 60 && num < 80)
            {
                Console.Write(num + " ");
            }
        }
        Console.WriteLine();

        // 80以上の数値を表示
        Console.Write("80以上：");
        foreach (int num in box)
        {
            if (num >= 80)
            {
                Console.Write(num + " ");
            }
        }
        Console.WriteLine();
    }
}

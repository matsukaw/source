using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[5]; //配列
        Random rand = new Random();
        for (int y = 0; y < arr.Length; y++)
        {
            arr[y] = rand.Next(1, 11); // 1から10までの乱数
        }
        Console.Write("配列：");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        int su = 0;
        foreach (int num in arr)   // 配列の値の合計値と平均値を計算
        {
            su += num;
        }
        double ave = (double)su / arr.Length;
        Console.WriteLine($"合計値：{su}");
        Console.WriteLine($"平均値：{ave}");
        // 表示：平均値より大きい数
        Console.Write("平均値より大きい：");
        foreach (int num in arr)
        {
            if (num > ave)
            {
                Console.Write(num + " ");
            }
        }
        Console.WriteLine();
        // 表示：平均値より小さい数を表示
        Console.Write("平均値より小さい：");
        foreach (int num in arr)
        {
            if (num < ave)
            {
                Console.Write(num + " ");
            }
        }
        Console.WriteLine();
    }
}
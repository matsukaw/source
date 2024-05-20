using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[5];
        Random rand = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-10, 11); // -10から10までの乱数
        }
 
        Console.WriteLine("配列：");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        int countPositive = 0;
        foreach (int num in array)　 // 0より大きい数が何個あるか数える
        {
            if (num > 0)
            {
                countPositive++;
            }
        }
        Console.WriteLine($"0より大きい数の個数：{countPositive}"); 
        int countNegative = 0;
        foreach (int num in array)　 // 0より小さい数が何個あるか数える
        {
            if (num < 0)
            {
                countNegative++;
            }
        }
        Console.WriteLine($"0より小さい数の個数：{countNegative}");   
        int countZero = 0;
        foreach (int num in array)  // 0が何個あるか数える
        {
            if (num == 0)
            {
                countZero++;
            }
        }
        Console.WriteLine($"0の個数：{countZero}");
    }
}
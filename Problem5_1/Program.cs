using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        
        int lot = 7; //配列指定

       
        int[] a = new int[lot];  // 配列の宣言と初期化

       
        Random rand = new Random();

        
        for (int num = 0; num < a.Length; num++) // 配列に乱数をいれる
        {
            a[num] = rand.Next(1, 11); // 1から10までの乱数
        }

        // 配列の表示
        Console.WriteLine("配列yの内容:");
        for (int index = 0; index < a.Length; index++)
        {
            Console.Write($"a[{index}]={a[index]} ");
        }
    }
}
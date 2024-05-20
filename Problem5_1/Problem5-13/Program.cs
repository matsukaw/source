using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {      
        int[,] box = new int[3, 3];//整数9までの乱数の箱を用意する
        Random rand = new Random();
        for (int a = 0; a < 3; a++)
            for (int n = 0; n < 3; n++)
                box[a, n] = rand.Next(10);
    
        Console.WriteLine("配列：");//箱から乱数の値を取得する
        for (int y = 0; y < 3; y++)
        {
            for (int x = 0; x < 3; x++)
                Console.Write(box[y, x] + " ");
            Console.WriteLine();
        }
        int max = box[0, 0], min = box[0, 0];//生成された値の中から最小値と最大値を取得する
        foreach (int num in box)
        {
            if (num > max)
                max = num;
            if (num < min)
                min = num;
        }
        Console.WriteLine($"最大値：{max}\n最小値：{min}");
    }
}

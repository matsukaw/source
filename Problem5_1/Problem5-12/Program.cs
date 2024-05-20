using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // 3×3の二次元配列を生成
        int[,] box = new int[3, 3];

        // 0から9までの乱数を各要素に代入
        Random rand = new Random();
        for (int a = 0; a < 3; a++)
        {
            for (int y = 0; y < 3; y++)
            {
                box[a, y] = rand.Next(10); // 0から9までの乱数を生成
            }
        }

        // 配列の内容を表示
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(box[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

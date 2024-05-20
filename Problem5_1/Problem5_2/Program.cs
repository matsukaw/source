using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {


        double[] d = new double[]{ 0.2, -5.1, 3.2, 1.8 }; //初期化


        // 配列の表示
        Console.Write("配列: ");
        for (int a = 0; a < d.Length; a++)
        {
            Console.Write($"d[{a}]={d[a]} ");
        }
    }
}
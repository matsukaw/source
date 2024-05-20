using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] arga)
    {
        int[] data = new int[10];
        Random rand = new Random();

        for(int a = 0; a < data.Length; a++)
        {
            data[a] = rand.Next(1,11);
        }
        Console.Write("値：");
         foreach(int num in data)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        int max = data[0];
        int min = data[0];
        int su = 0;
         foreach(int num in data)
        {
            if (num > max)
            {
                max = num;
            }
            if(num < min)
            {
                min = num;
            }
            su += num;
        }
        double ave = (double)su / data.Length;
        Console.WriteLine($"最大値:{max}");
        Console.WriteLine($"最小値:{min}");
        Console.WriteLine($"平均値:{ave}");
    } 
} 
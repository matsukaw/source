using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
     static void Main (string[] args)
    {
        Random rand = new Random();
        int[] date = new int[10]; //

        for(int a=0; a< date.Length; a++)
        {
            date[a] = rand.Next(1, 11);
        }

        Console.Write("値：");
         foreach(var num in date)
        {
            Console.Write($"{num}");
        }

        Console.Write(" ");
        Console.Write("\n3の倍数：");
        for (int a = 0; a < date.Length; a++)
        {
            if (date[a] % 3 == 0)
            {
                Console.Write($"{date[a]} ");
            }
        }

        Console.WriteLine();
        Console.Write("3の倍数以外：");
        for (int a = 0; a < date.Length; a++)
        {
            if (date[a] % 3 != 0)
            {
                Console.Write($"{date[a]} ");
            }
        }

        Console.WriteLine();
    }
}
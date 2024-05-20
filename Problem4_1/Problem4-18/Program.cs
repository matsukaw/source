using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int size = 10; // サイズ

        for (int a = 0; a < size; a++)
        {
            
            for (int y = 0; y < a; y++) // □を出力
            {
                Console.Write("□");
            }

            
            Console.Write("■"); // ■を出力


            for (int y = 0; y < size - a - 1; y++) // (size - a - 1)回分の□を出力
            {
                Console.Write("□");
            }

            Console.WriteLine(); 
        }
    }
}

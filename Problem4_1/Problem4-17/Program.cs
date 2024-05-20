using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int size = 10; //サイズ

        for (int a = 0; a < size; a++) //10までループさせる
        {
            
            for (int y = 0; y < a; y++) 
            {
                Console.Write("■");　//ループごとに■が減る
            }

            
            for (int y = 0; y < size - a; y++)　//size - aでループごとに□を増やす
            {
                Console.Write("□");
            }

            Console.WriteLine(); 
        }
    }
}

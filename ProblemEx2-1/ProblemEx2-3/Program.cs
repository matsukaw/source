using System;

namespace Problemex2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random(); //乱数
            int a = r.Next(1, 11);  
            int b = r.Next(1, 11);  

            Console.WriteLine("たて" + a);　//縦と横の乱数を表示
            Console.WriteLine("よこ" + b);
            Square(a, b);  

           
        }
        static void Square(int a, int b)
        {
            if (a == 0 || b == 0)　//0は表示無し
                return;
            for (int y = 0; y < a; y++)　　//0以外の乱数の時に■を表示するループ
            {
                for (int x = 0; x < b; x++)
                {
                    Console.Write("■");
                }
                Console.WriteLine(); 
            }
        }
    }
}

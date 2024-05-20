using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature; //条件分岐で必要な為、ここで定義。

            Console.Write("今日の気温を入力してください(該当数値：-10～35)：");
            string input = Console.ReadLine();


            if (!int.TryParse(input, out temperature))  // 入力が数値か確認、整数に変換
            {
                Console.WriteLine("数値を入力してください。");
                return;
            }
            if (temperature >= -10 && temperature <= 35)
            {
                Console.WriteLine($"今日の気温は摂氏{temperature}度です。");

                if (temperature >= 30)
                {
                    Console.WriteLine("真夏日です。");
                }
                else if (temperature >= 25)
                {
                    Console.WriteLine("夏日です。");
                }
                else if (temperature < 0)
                {
                    Console.WriteLine("真冬日です。");
                }
            }
            else
            {
                Console.WriteLine("温度は-10から35の範囲で入力してください。");
            }
        }
    }
}
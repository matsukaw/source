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
            Console.WriteLine("1から100までの整数値を入力してください：");
            int num;
            string input = Console.ReadLine();
            if (!int.TryParse(input, out num))
            {
                Console.WriteLine("正しい整数値を入力してください。");
            }
            else if (num < 1 || num > 100)
            {
                Console.WriteLine("1から100の範囲外です。");
            }
            else if (num <= 50 && num % 2 == 0) // 50以下かつ偶数の場合
            {
                Console.WriteLine("50以下の偶数です。");
            }
            else if (num <= 50) // 50以下かつ奇数の場合
            {
                Console.WriteLine("50以下です。");
            }
            else if (num % 2 == 0) // 50より大きい場合の偶数
            {
                Console.WriteLine("偶数です。");
            }
        }
    }
}

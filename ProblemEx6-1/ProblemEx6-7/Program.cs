using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemEx6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(); // リスト生成
            Random rand = new Random();

            while (true)
            {
                int num = rand.Next(0, 11); // 0を含む範囲で乱数を生成
                Console.Write("値：" + num + " "); // 乱数値を表示

                if (num == 0)
                {
                    break;
                }

                numbers.Add(num); // リストに数値を追加
                numbers.Sort(); 

                Console.Write("今までの値：");
                foreach (int a in numbers) // 格納してる値を全表示
                {
                    Console.Write(a + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
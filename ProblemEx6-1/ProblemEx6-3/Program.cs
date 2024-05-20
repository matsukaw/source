using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProblemEx6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList numbers = new ArrayList();
            Random ran = new Random();

            while (true)
            {
                int num = ran.Next(0, 101);
                Console.WriteLine("出力値: " + num);

                numbers.Add(num);

                if (num == 0)
                    break;
            }
            SameUnit(numbers);// 各1の位を表示
        }
        static void SameUnit(ArrayList numbers)
        {
            Console.WriteLine("一の位が0～9の値を表示:");
            ArrayList[] unitLists = new ArrayList[10];// 各リストを作成
            for (int i = 0; i < 10; i++)
            {
                unitLists[i] = new ArrayList();
            }
            foreach (int num in numbers)
            {
                int unit = num % 10; // 1の位を取得
                unitLists[unit].Add(num); // 対応する1の位に追加
            }
            for (int i = 0; i < 10; i++)
            {
                if (unitLists[i].Count > 0)
                {
                    Console.Write($"1の位が{i} : ");
                    foreach (int num in unitLists[i])
                    {
                        Console.Write(num + " ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"1の位{i} : なし");
                }
            }
        }
    }
}
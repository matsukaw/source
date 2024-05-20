using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemEx6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> even = new List<int>();
            List<int> odd = new List<int>();
            Random ran = new Random();

            Numbers(ran, even, odd);
        }

        static void Numbers(Random rand, List<int> even, List<int> odd)
        {
            while (true)
            {
                int num = rand.Next(0, 11);
                Console.WriteLine("0～10の値を出力:" + num); //乱数生成

                if (num == 0) //0で出力の終了
                    break;

                Classify(num, even, odd);　//分類へ
            }

            Result("偶数", even);
            Result("奇数", odd);
        }

        static void Classify(int num, List<int> even, List<int> odd)//分類処理
        {
            if (num % 2 == 0)
                even.Add(num);
            else
                odd.Add(num);
        }

        static void Result(string type, List<int> numbers) //分類後の表示
        {
            Console.Write($"{type} : ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
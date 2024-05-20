using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemEx6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Generate();
            Reverse(numbers);
        }
        // 乱数をリストに格納する
        static List<int> Generate()
        {
            List<int> numbers = new List<int>();
            Random ran = new Random();
            while (true)
            {
                int num = ran.Next(0, 11);
                Console.WriteLine($"0～10の値を出力: {num}");
                if (num == 0)
                    break;
              numbers.Add(num);
            }
            return numbers;
        }
        static void Display(List<int> numbers)
        {
            Console.WriteLine("入力した整数:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        static void Reverse(List<int> numbers)
        {
            Console.WriteLine("逆順に表示:");
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
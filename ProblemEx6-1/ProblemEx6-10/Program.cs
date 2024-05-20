using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemEx6_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> box = new List<int>();

            Console.Write("乱数: ");
            for (int i = 0; i < 10; i++)　//乱数を10回生成する
            {
                int randomNumber = random.Next(1, 11);
                Console.Write(randomNumber + " "); //表示する
                box.Add(randomNumber); //リストに格納
            }
            Console.WriteLine();
            Console.Write("被ってない数字: ");
            for (int i = 1; i <= 10; i++) //全部引き出す
            {
                if (OnlyNumber(box, i))
                {
                    Console.Write(i + " ");
                }
            }
        }
        static bool OnlyNumber(List<int> list, int number)
        {
            foreach (int num in list)
            {
                if (num == number) //被ってるか判断して返す
                {
                    return true;
                }
            }
            return false;
        }
    }
}
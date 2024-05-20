using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1から3の数値を入力してください: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("グー");
                    break;
                case 2:
                    Console.WriteLine("パー");
                    break;
                case 3:
                    Console.WriteLine("チョキ");
                    break;
                default:
                    Console.WriteLine("正しい値ではありません");
                    break;
            }
        }
    }
}
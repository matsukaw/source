using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("何か100までの整数値を入力してください: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num <= 20 || num >= 80)
            {
                Console.WriteLine("この値は20以下か80以上の値です");
            }
        }
    }
}

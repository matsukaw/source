using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("何か100までの整数値を入力してください: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 50)
            {
                Console.WriteLine("この値は50未満です");
            }
        }
    }
}
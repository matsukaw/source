using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("何か100までの整数値を入力してください: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 30 && num <= 70)
            {
                Console.WriteLine("この値は30より大きく70以下です");
            }
        }
    }
}

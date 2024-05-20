using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemEx6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>();
            Random ran = new Random();

            while (true)
            {
                int nums = ran.Next(0, 11);
                Console.WriteLine("値：" + nums);

                if (nums == 0) //0でbreakする
                {
                    Console.WriteLine("0が出たので終了します。");
                    break;
                }

                num.Add(nums); 
            }

            if (num.Contains(2)) //判定
            {
                num.Remove(2);
            }

            Console.Write("2を除いた値: ");
            foreach (int n in num)
            {
                Console.Write(n + " ");
            }
        }
    }
}
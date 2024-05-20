using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("誕生月を入力してください: ");
            string str1 = Console.ReadLine();

            Console.Write("誕生日を入力してください: "); 
            string str2 = Console.ReadLine(); 

            string result = str1 + str2; 

            Console.WriteLine("誕生日は " + result); 
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProblemEx6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputs = new List<string>();
            while (true)
            {
                string input = Read();
                if (string.IsNullOrEmpty(input))//空か判別する
                {
                   Inputs(inputs);
                    break;
                }
                inputs.Add(input);
            }
        }
        static string Read()
        {
            Console.Write("何か文字列を入力してください: ");
            return Console.ReadLine();
        }
        static void Inputs(List<string> inputs)
        {
            Console.WriteLine("入力された文字列:");
            foreach (string input in inputs)
            {
                Console.Write(input + " ");
            }
        }
    }
}
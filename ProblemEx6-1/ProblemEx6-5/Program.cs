using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemEx6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wordinput = new List<string>();
            while (true)
            {
                Console.Write("何か文字列を入力してください: ");
                string input = Console.ReadLine();　//入力を文字列とする
                if (string.IsNullOrEmpty(input)) //     nullでbreakする
                {
                    break;
                }
                wordinput.Add(input); //入力した文字列の箱詰め
            }
            Strings(wordinput);
        }
        static void Strings(List<string> inputs)//入力した全ての文字列のリスト
        {
            Console.Write("5文字以下の文字列:");

            foreach (string input in inputs) //入力された文字が５文字以下か判定
            {
                if (input.Length < 5)
                {
                    Console.Write(input + " "); 
                }
            }
        }
    }
}

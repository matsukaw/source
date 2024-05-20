using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemEx6_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, string> kanji = new Dictionary<char, string>()
            {
                { '0', "〇" },
                { '1', "一" },
                { '2', "二" },
                { '3', "三" },
                { '4', "四" },
                { '5', "五" },
                { '6', "六" },
                { '7', "七" },
                { '8', "八" },
                { '9', "九" }
            };
            while (true)
            {
                Console.Write("整数の値を入力してください:");
                string input = Console.ReadLine();
                // 入力が整数かどうかをチェック
                if (!word(input))
                {
                    Console.WriteLine("整数ではありません。");
                    continue;
                }
                Console.WriteLine("変換結果:" + Convert(input, kanji));
            }
        }
        // 入力が整数かどうかをチェックするメソッド
        static bool word(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        // 数字を漢数字に変換するメソッド
        static string Convert(string input, Dictionary<char, string> kanjiMap)
        {
            string kanji = "";
            int length = input.Length;
            int count = 0;

            // 3桁ごとにカンマを挿入しながら漢数字に変換
            for (int i = 0; i < length; i++)
            {
                char digit = input[i];
                string kanjiDigit = kanjiMap[digit];
                kanji += kanjiDigit;

                count++;
                
                if ((length - count) % 3 == 0 && count < length)
                {
                    kanji += ","; // 3桁ごとにカンマを挿入
                }
            }

            return kanji;
        }
    }
}
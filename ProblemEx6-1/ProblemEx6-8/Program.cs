using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemEx6_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 英単語と日本語の対応表を作成
            Dictionary<string, string> word = new Dictionary<string, string>()
            {
                { "cat", "猫" },
                { "dog", "犬" },
                { "bird", "鳥" },
                { "tiger", "トラ" }
            };

            // ユーザーに英単語を入力してもらう
            Console.Write("英語で動物の名前を入力してください：");
            string input = Console.ReadLine();

            // 入力された英単語が辞書に含まれているかをチェックし、対応する日本語を表示
            if (word.ContainsKey(input))
            {
                string japanese = word[input];
                Console.WriteLine($"「{japanese}」です。");
            }
            else
            {
                Console.WriteLine("その単語の日本語訳は登録されていません。");
            }
        }
    }
}
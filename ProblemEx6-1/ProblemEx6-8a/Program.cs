using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // 英単語と日本語の対応表を作成
        Dictionary<string, string> dictionary = new Dictionary<string, string>()
            {
                { "cat", "猫" },
                { "dog", "犬" },
                { "bird", "鳥" },
                { "tiger", "トラ" }
            };

        while (true)
        {
            // ユーザーに英単語を入力してもらう
            Console.Write("英語で動物の名前を入力してください：");
            string input = Console.ReadLine();

            // 入力された英単語が辞書に含まれているかをチェックし、対応する日本語を表示
            if (dictionary.ContainsKey(input))
            {
                string japanese = dictionary[input];
                Console.WriteLine($"「{japanese}」です。");
            }
            else
            {
                Console.WriteLine("その単語の日本語訳は登録されていません。");
                Console.WriteLine("登録しますか？ 1: はい, 2: いいえ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("日本語訳を入力してください：");
                    string japanese = Console.ReadLine();
                    dictionary.Add(input, japanese);
                    Console.WriteLine("登録されました。");
                }
                else
                {
                    Console.WriteLine("登録をキャンセルしました。");
                }
            }

            // プログラムを続行するかどうかを確認
            Console.WriteLine("続けますか？ 1: はい, 2: いいえ");
            string continueChoice = Console.ReadLine();
            if (continueChoice != "1")
            {
                break;
            }
        }
    }
}
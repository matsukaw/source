﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("0以上の数値を入力してください: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 0)　// ０より上ならループ
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("終了します");
                break; // ループから抜ける
            }
        }
    }
}

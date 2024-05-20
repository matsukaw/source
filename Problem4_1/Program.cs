using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("数: ");
        int number = int.Parse(Console.ReadLine());

        // 入力された数だけ■マークを表示する
        for (int i = 0; i < number; i++)
        {
            Console.Write("■");
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("数: ");
        int number = int.Parse(Console.ReadLine());

        // 入力された数だけ■を表示する whileはループ外処理
        int count = 0;
        while (count < number)
        {
            Console.Write("■");
            count++;
        }
    }
}

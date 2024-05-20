using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("数: ");
        int number = int.Parse(Console.ReadLine());

        // 入力された数だけ■を表示する
        int count = 0;
        do
        {
            Console.Write("■");
            count++;
        } while (count < number);
    }
}

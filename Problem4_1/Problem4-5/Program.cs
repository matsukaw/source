using System;
namespace problem4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // numの初期値を3としてループを開始する、0になるまでループする
            for (int num = 3; num >= 0; num--)
            {
                Console.WriteLine("num = " + num);
            }
        }
    }
}
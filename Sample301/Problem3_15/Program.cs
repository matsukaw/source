using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Problem3_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("点数（1-100を範囲とする）を入力してください:");
            int score = int.Parse(Console.ReadLine());　//入力したスコアを表示する為のscoreを定義。

             if (score >= 80 && score <= 100) //80点以上
            {
                Console.WriteLine("優");
            }
             else if (score >= 70 && score < 80)　//80点未満、70点以上
            {
                Console.WriteLine("良");
            }
             else if (score >=60 && score < 70)　//70点未満、60点以上
            {
                Console.WriteLine("可");
            }
             else if (score >=0 && score < 60)　//60点未満、”不可”
            {
                Console.WriteLine("不可");
            }
            else 　　　　　　　　　　　　　　
            {
                Console.WriteLine("範囲外");　//それ以外を範囲外とする
            }

        }
    }
}

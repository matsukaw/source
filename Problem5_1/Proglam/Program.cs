using System;

class Program
{
    static void Main(string[] args)
    {        
        int[] box = new int[10];// 長さ10のint型配列作成
        Random rand = new Random();
        for (int a = 0; a < box.Length; a++)
        {
            box[a] = rand.Next(101); 
        }
        Console.Write("配列：");
        foreach (int num in box)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        Console.Write("50以上の数：");   // 50以上の数
        foreach (int num in box)
        {
            if (num >= 50)
            {
                Console.Write(num + " ");
            }
        }
        Console.WriteLine();
        Console.Write("50未満の数："); // 50未満の数
        foreach (int num in box)
        {
            if (num < 50)
            {
                Console.Write(num + " ");
            }
        }
        Console.WriteLine();
        int Zero = 0;
        foreach (int num in box)  // 文字列の0として０を判別
        {
            if (num.ToString().Contains("0"))
            {
                Zero++;
            }
        }
        Console.Write($"0の個数：{Zero}個");
    }
}

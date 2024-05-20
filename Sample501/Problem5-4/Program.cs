class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int[] data = new int[100]; // 100に設定

        // 配列に1から101までの乱数を代入する
        for (int i = 0; i < data.Length; i++)
        {
            data[i] = rand.Next(1, 101);
        }

        Console.WriteLine("値をすべて表示:");
        foreach (var num in data)
        {
            Console.Write($"{num} ");
        }

        Console.WriteLine();
        Console.Write("\n50以上の数：");
        foreach (var num in data)
        {
            if (num >= 50)
            {
                Console.Write($"{num} ");
            }
        }

        Console.WriteLine();
        Console.Write("50未満の数：");
        foreach (var num in data)
        {
            if (num < 50)
            {
                Console.Write($"{num} ");
            }
        }

        Console.WriteLine();
    }
}
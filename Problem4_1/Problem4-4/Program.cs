using System;

class Program
{
    static void Main(string[] args)
    {
        int num = 3;　　　　　　 //numの初期値を設定

        
        while (num >= 0)　　　　　// numが0以上の間ループを続ける
        {
            Console.WriteLine("num = " + num);
           　　　 num--; 　　　　// numを1減少させる
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx402
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird[] b = new Bird[2];     //  Birdクラスの変数の配列を生成
            b[0] = new Crow();         //  b[0]に、Crow2クラスのインスタンスを生成
            b[1] = new Sparrow();      //  b[1]に、Sparrow2クラスのインスタンスを生成
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i].Name + " : ");
                b[i].Sing();
            }
        }
    }
}

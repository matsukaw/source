using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemEx4_3a
{
    internal class Program
    {
      private static void Main(string[] args)
        {
            // 四角形の生成
            var b = new Box(2.0, 4.0);
            // 三角形の生成
            var t = new Triangle(4.0, 1.5);
            Console.WriteLine($"幅{b.Width}、高さ{b.Height}の四角形の面積は{b.Area}");
            Console.WriteLine($"幅{t.Width}、高さ{t.Height}の三角形の面積は{t.Area}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            Area d = new Area();
            //  円の半径を設定
            c.r = 4.0;
            d.r = 4.0;
            Console.WriteLine("半径4.0の円の円周の長さは" + c.Circumference());
            Console.WriteLine("半径4.0の円の面積は" + d.GetArea());
        }
    }
}
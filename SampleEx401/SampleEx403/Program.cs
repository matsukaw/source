using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx403
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v = new Vector();
            v.X = 0.1;
            v.Y = 0.2;
            Console.WriteLine("v=({0},{1})", v.X, v.Y);
        }
    }
}
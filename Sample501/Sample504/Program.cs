using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample504
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 2, 3, 4 };
            foreach (int i in n)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
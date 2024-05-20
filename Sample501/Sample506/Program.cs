using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample506
{
    class program
    {
        static void Main(string[] arga)
        {
            int[][] a = new int[][] { new int[] { 0, 1 }, new int[] { 2 }, new int[] { 3, 4, 5, 6 } };

            for (int m = 0; m < a.Length; m++)
            {
                for (int n = 0; n < a[m].Length; n++)
                {
                    Console.Write(a[m][n] + "");
                }
                Console.WriteLine();
            }

        }
    }

}
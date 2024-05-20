using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6_3
{
    class Circle
    {
        //  半径
        public double r;
       
        public double Circumference()　 //  円周の長さを求める
        {
            return 2 * 3.14 * r;
        }
    }

    class Area
    {
        public double r;
        public double GetArea()　 //  円周の面積を求める
        {
            return r * r * 3.14;
        }
    }

}
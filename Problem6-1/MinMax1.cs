using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6_1
{
    //  最大値と最小値を求めるクラス
    class MinMax
    {
        //  最大値の取得
        public int Max(int n1, int n2, int n3)
        {
            int max = n1;
            if (n2 > max)
            {
                max = n2;
            }
            if (n3 > max)
            {
                max = n3;
            }
            return max;
        }
        //  最小値の取得
        public int Min(int n1, int n2, int n3)
        {
            int min = n1;
            if (n2 < min)
            {
                min = n2;
            }
            if (n3 < min)
            {
                min = n3;
            }
            return min;
        }
    }
}
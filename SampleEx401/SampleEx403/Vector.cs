using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx403
{
    class Vector : VectorBase
    {
        private double x = 0.0;
        private double y = 0.0;
        //  プロパティの実装
        public override double X
        {
            set { x = value; }
            get { return x; }
        }
        public override double Y
        {
            set { y = value; }
            get { return y; }
        }
    }
}
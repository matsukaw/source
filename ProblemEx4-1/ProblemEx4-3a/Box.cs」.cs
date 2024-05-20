using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemEx4_3a

{
    // 平面図形の抽象クラス
    internal abstract class Box:PlaneFigure
    {
        protected double Width { get; set; }
        protected double Height { get; set; }

        public Box(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // 面積のプロパティ
        public override double Area { get { return Width * Height; } } 
    }
}

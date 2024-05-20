using ProblemEx4_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemex4_2
{
    //  四角形クラス
     class Box : PlaneFigure
    {
        //  幅
        private double width = 0;
        //  高さ
        private double height = 0;

      
        //  コンストラクタ（引数あり）
        public Box(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        //  幅のプロパティ
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        //  高さのプロパティ
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public override double Area
        {
            get { return width * height; }
        }
    }
}
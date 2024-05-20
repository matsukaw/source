using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx302
{
    //  サブクラス（Superクラスを継承）
    class Sub : Super
    {
        //  Subクラスのコンストラクタ
        public Sub()
        {
            Console.WriteLine("Subのコンストラクタ(引数なし)");
        }
        //  Subクラスのコンストラクタ
        public Sub(int param) : base(param)
        {
            Console.WriteLine("Subのコンストラクタ（引数:param={0}）", param);
        }
        //  Subクラスのデストラクタ
        ~Sub()
        {
            Console.WriteLine("Subクラスのデストラクタ");
        }
    }
}
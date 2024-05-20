using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemex3_1
{
     class Fighter : Airplane
    {
        //Airplane クラスを継承するサブクラスで Fly メソッドをオーバーライド
        public override void Fly() 
        {
            Console.WriteLine("飛行する");
        }
        public  void Fight()
        {
            Console.WriteLine("戦闘する");
        }
    }
}
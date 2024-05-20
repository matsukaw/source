using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemex1_3
{
    class Sample
    {
        public Sample()
        {
            Console.WriteLine("スタート");
        }
        public void func()
        {
            Console.WriteLine("func");
        }
    
        public void End()
        {
            Console.WriteLine("エンド");  //オブジェクトの破壊で呼ばれたら「エンド」を表示
        }
    }
}
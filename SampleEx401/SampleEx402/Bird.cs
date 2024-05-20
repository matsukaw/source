using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx402
{
    abstract class Bird
    {
        //  名前フィールド
        private String name;
        //  引数つきコンストラクタ
        public Bird(String name)
        {
            this.name = name;
        }
        // 名前を取得
        public String Name
        {
            get { return name; }
        }
        //  鳴く（抽象メソッド）
        public abstract void Sing();
    }
}
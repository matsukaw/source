using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemex2_4
{
    class Counter
    {
        private static int totalCount = 0; //トータルカウント追加
        //  カウント
        private int count = 0;
       
                                           
        //  コンストラクタ
        public void Reset()
        {
            count = 0;
        }
        //  カウントのインクリメント
        public void Increment()
        {
            count++;
            totalCount++; //トータルカウントもインクリメント
        }
        //  回数のプロパティ
        public int Count
        {
            get
            {
                return count;
            }
        }
        //静的プロパティの作成
        public static int TotalCount
        {
            get
            {
                return totalCount; //TotalCountなっていたのを修正
            }
        }
    }
    
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx501
{
    //  電子メール
    interface IEmail
    {
        //  メールを送る
        void SendMail(string address);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemex5_1
{
    // If.cs　クラス無し
    // 電話IF
    interface IPhone
    {
        void CallPhone();
        void RecievePhone();
    }

    // mailIF
    interface IMailer
    {
        void SendMail();
        void RecieveMail();
    }

    // CPIF
    interface IComputer
    {
        void PlayGame();
        void BrowseWeb();
    }
}

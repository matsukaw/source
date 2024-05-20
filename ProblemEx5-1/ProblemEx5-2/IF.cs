using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemEx5_2
{

    internal interface IAlarm //アラーム関連のIF
        {
            abstract void SetAlarm();
            abstract void Alarm();
            abstract void StopAlarm();
        }
    internal interface IClock //時計関連のIF
        {
            abstract void AdjustTime();
            abstract void ShowTime();
        }
    
}

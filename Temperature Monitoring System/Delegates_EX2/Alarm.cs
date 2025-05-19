using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_EX2
{
    internal class Alarm
    {
        private int AlarmValue { get; set; } //Threshold

        public Alarm(int alarmTemp)
        {
            AlarmValue = alarmTemp;
        }
        public void SetAlarmValue(int newAlarmValue)
        {
            AlarmValue = newAlarmValue;
        }

        public void FireAlarm(object? objecct, TempArgs tempArgs)
        {
            if (tempArgs.Tempreture > AlarmValue)
            {
                Console.WriteLine($"Take Care, The Tempreture Is Very High !{tempArgs.Tempreture}!");
            } 
        }
    }
}

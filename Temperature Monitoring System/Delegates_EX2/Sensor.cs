using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_EX2
{
    internal class Sensor
    {
        // Declare Event 
        public event EventHandler<TempArgs>? SensorChanged;
        private int CurrentTemp { get; set; }
        public void ChangeTempreture(int NewTemp)
        {
            CurrentTemp = NewTemp;
            SensorChanged.Invoke(this, new TempArgs(NewTemp));
        }
    }
}

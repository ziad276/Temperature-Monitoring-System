using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_EX2
{
    internal class TempArgs: EventArgs
    {
        public int Tempreture { get; set; }
        public TempArgs(int temp)
        {
            Tempreture = temp;
        }
    }
}

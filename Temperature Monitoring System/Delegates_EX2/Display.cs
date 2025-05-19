using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_EX2
{
    internal class Display
    {
        public void ShowTemp(object? obj, TempArgs args)
        {
            Console.WriteLine("The Tempreture Now Set To" + args.Tempreture + "From Display");
        }
    }
}

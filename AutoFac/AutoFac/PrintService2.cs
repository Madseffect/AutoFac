using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFac
{
    class PrintService2:IPrintService2
    {
        public void PrintSomething2(string text)
        {
            Console.WriteLine(text+" yay i think i figured it out");
        }
    }
}
}

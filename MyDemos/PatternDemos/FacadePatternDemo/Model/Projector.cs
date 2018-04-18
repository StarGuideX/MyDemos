using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.FacadePatternDemo.Model
{
    public class Projector
    {
        internal void On()
        {
            Console.WriteLine("调用了Projector的On方法...");
        }
        internal void WideScreenMode()
        {
            Console.WriteLine("调用了Projector的WideScreenMode方法...");
        }

        internal void Off()
        {
            Console.WriteLine("调用了Projector的Off方法...");
        }
    }
}

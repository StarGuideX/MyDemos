using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.FacadePatternDemo.Model
{
    public class Amplifier
    {
        internal void On()
        {
            Console.WriteLine("调用了Amplifier的On方法...");
        }

        internal void SetDvd(DvdPlayer _dvd)
        {
            Console.WriteLine("调用了Amplifier的On方法...DvdPlayer为" + _dvd + "...");
        }

        internal void SetSurroundSound()
        {
            Console.WriteLine("调用了Amplifier的SetSurroundSound方法...");
        }

        internal void SetVolume(int v)
        {
            Console.WriteLine("调用了Amplifier的On方法...Value为" + v + "...");
        }

        internal void Off()
        {
            Console.WriteLine("调用了Amplifier的Off方法...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.FacadePatternDemo.Model
{
    public class DvdPlayer
    {
        internal void On()
        {
            Console.WriteLine("调用了DvdPlayer的On方法...");
        }
        internal void Play(string movie)
        {
            Console.WriteLine("调用了DvdPlayer的Play方法...电影为：" + movie + "...");
        }

        internal void Stop()
        {
            Console.WriteLine("调用了DvdPlayer的Stop方法...");
        }

        internal void Eject()
        {
            Console.WriteLine("调用了DvdPlayer的Eject方法...");
        }

        internal void Off()
        {
            Console.WriteLine("调用了DvdPlayer的Off方法...");
        }
    }
}

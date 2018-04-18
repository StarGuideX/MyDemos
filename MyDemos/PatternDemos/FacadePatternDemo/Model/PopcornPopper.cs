using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.FacadePatternDemo.Model
{
    public class PopcornPopper
    {
        internal void On()
        {
            Console.WriteLine("调用了PopcornPopper的On方法...");
        }

        internal void Pop()
        {
            Console.WriteLine("调用了PopcornPopper的Pop方法...");
        }

        internal void Off()
        {
            Console.WriteLine("调用了PopcornPopper的Off方法...");
        }
    }
}

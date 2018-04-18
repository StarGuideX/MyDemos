using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.FacadePatternDemo.Model
{
    public class TheaterLights
    {
        internal void Dim(int v)
        {
            Console.WriteLine("调用了TheaterLights的Dim方法...Value为" + v + "...");
        }

        internal void On()
        {
            Console.WriteLine("调用了TheaterLights的On方法...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.ObserverPatternDemo.Weather
{
    //当布告板需要显示时，调用此方法。
    public interface DisplayElement
    {
        void Display();
    }
}

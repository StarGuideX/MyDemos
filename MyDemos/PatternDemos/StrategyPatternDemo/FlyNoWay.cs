using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.StrategyPatternDemo
{
    // 是飞行行为的实现，给不会飞的鸭子用的
    public class FlyNoWay : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("我不会飞！");
        }
    }
}

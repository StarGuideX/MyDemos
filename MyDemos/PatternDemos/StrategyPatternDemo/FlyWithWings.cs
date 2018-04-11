using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.StrategyPatternDemo
{
    // 是飞行行为的实现，给会飞的鸭子使用
    public class FlyWithWings : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("我在飞！");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.StrategyPatternDemo
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            base.quackBehavior = new Quack();
            base.flyBehavior = new FlyNoWay();
        }


        public override void Display()
        {
            Console.WriteLine("I'm a mallarDuck");
        }
    }
}

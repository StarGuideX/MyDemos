using PatternDemos.StrategyPatternDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 策略模式验证
            Duck mallardDuck = new MallardDuck();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();
            mallardDuck.SetFlyBehavior(new FlyWithWings());
            mallardDuck.SetQuackBehavior(new Quack());
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();
            Console.ReadLine();
            #endregion
        }
    }
}

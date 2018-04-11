using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.StrategyPatternDemo
{
    public abstract class Duck
    {
        //为行为接口声明两个引用变量，所有鸭子类都继承它们。
        protected FlyBehavior flyBehavior;
        protected QuackBehavior quackBehavior;

        public Duck()
        {
        }

        //委托给行为类，运行时改变行为，调用
        public void SetFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }

        //委托给行为类，运行时改变行为，调用
        public void SetQuackBehavior(QuackBehavior qb)
        {
            quackBehavior = qb;
        }
        public abstract void Display();

        // 叫
        public void PerformQuack()
        {
            quackBehavior.Quack();
        }
        //飞
        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float,even decoys!");
        }
    }
}

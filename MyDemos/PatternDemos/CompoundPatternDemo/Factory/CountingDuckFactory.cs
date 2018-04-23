using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternDemos.CompoundPatternDemo.Entity;

namespace PatternDemos.CompoundPatternDemo.Factory
{
    /// <summary>
    /// 使用工厂和装饰者，创建被装饰的鸭子
    /// </summary>
    public class CountingDuckFactory : AbstractDuckFactory
    {
        //使用装饰者，创建被装饰的鸭子
        public override IQuackable CreateBlueheadDuck()
        {
             return new QuackCounter(new BlueheadDuck());
        }
        //使用装饰者，创建被装饰的鸭子
        public override IQuackable CreateDuckCall()
        {
            return new QuackCounter(new DuckCall());
        }
        //使用装饰者，创建被装饰的鸭子
        public override IQuackable CreatePinkheadDuck()
        {
            return new QuackCounter(new PinkheadDuck());
        }
        //使用装饰者，创建被装饰的鸭子
        public override IQuackable CreateRubberDuck()
        {
            return new QuackCounter(new RubberDuck());
        }
    }
}

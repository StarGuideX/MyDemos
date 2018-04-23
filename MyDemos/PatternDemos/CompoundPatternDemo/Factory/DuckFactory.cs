using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternDemos.CompoundPatternDemo.Entity;

namespace PatternDemos.CompoundPatternDemo.Factory
{
    /// <summary>
    /// 使用工厂，创建没有被装饰的鸭子
    /// </summary>
    public class DuckFactory : AbstractDuckFactory
    {
        //使用工厂，创建没有被装饰的鸭子
        public override IQuackable CreateBlueheadDuck()
        {
            return new BlueheadDuck();
        }

        //使用工厂，创建没有被装饰的鸭子
        public override IQuackable CreateDuckCall()
        {
            return new DuckCall();
        }

        //使用工厂，创建没有被装饰的鸭子
        public override IQuackable CreatePinkheadDuck()
        {
            return new PinkheadDuck();
        }

        //使用工厂，创建没有被装饰的鸭子
        public override IQuackable CreateRubberDuck()
        {
            return new RubberDuck();
        }
    }
}

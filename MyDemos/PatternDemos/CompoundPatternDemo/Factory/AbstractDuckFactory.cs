using PatternDemos.CompoundPatternDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.CompoundPatternDemo.Factory
{
    /// <summary>
    /// 抽象工厂类
    /// </summary>
    public abstract class AbstractDuckFactory
    {
        public abstract IQuackable CreateBlueheadDuck();
        public abstract IQuackable CreatePinkheadDuck();
        public abstract IQuackable CreateDuckCall();
        public abstract IQuackable CreateRubberDuck();
    }
}

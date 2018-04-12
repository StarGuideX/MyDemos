using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.DecoratePatternDemo
{
    //调料
    public abstract class CondimentDecorate : Beverage
    {
        //所有调料装饰者都必须重现实现此方法
        public abstract override string GetDescription();
    }
}

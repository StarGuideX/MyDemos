using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.DecoratePatternDemo
{
    //奶泡
    public class Whip : CondimentDecorate
    {
        Beverage _beverage;

        public Whip(Beverage beverage)
        {
            this._beverage = beverage;
        }

        public override double cost()
        {
            return .10 + _beverage.cost();
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + "，奶泡";
        }
    }
}

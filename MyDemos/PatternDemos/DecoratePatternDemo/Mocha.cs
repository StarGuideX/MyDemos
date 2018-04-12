using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.DecoratePatternDemo
{
    //摩卡
    public class Mocha : CondimentDecorate
    {
        Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            this._beverage = beverage;
        }

        public override double cost()
        {
            return .20 + _beverage.cost();
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + "，摩卡";
        }
    }
}

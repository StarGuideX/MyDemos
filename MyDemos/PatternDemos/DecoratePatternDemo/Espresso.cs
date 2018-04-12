using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.DecoratePatternDemo
{
    //意式浓缩咖啡
    public class Espresso : Beverage
    {
        public Espresso()
        {
            base.description = "意式浓缩咖啡";
        }

        public override double cost()
        {
            return 1.99;
        }
    }
}

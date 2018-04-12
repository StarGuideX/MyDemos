using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.DecoratePatternDemo
{
    //饮料
    public abstract class Beverage
    {
        protected string description = "咖啡类型无法确认";

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}
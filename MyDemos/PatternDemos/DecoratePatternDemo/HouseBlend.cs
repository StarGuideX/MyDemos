﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.DecoratePatternDemo
{
    //首选咖啡
    public class HouseBlend :Beverage
    {
        public HouseBlend()
        {
            base.description = "首选咖啡";
        }

        public override double cost()
        {
            return .89;
        }
    }
}

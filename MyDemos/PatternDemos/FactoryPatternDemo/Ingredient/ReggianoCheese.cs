﻿using PatternDemos.FactoryPatternDemo.Ingredient.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.FactoryPatternDemo.Ingredient
{
    public class ReggianoCheese : Cheese
    {
        public ReggianoCheese()
        {
            Console.WriteLine("ReggianoCheese");
        }
    }
}

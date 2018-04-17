﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.AdapterPatternDemo.ClassAdapter
{
    public class MallardDuck : Duck
    {
        public void Fly()
        {
            Console.WriteLine("鸭子Fly");
        }

        public void Quack()
        {
            Console.WriteLine("鸭子Quack");
        }
    }
}

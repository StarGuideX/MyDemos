using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.TemplateMethodDemo
{
    public class Tea : CaffeineBeverage
    {
        internal override void AddCondiments()
        {
            Console.WriteLine("加入柠檬");
        }

        internal override void Brew()
        {
            Console.WriteLine("加入茶叶");
        }
    }
}

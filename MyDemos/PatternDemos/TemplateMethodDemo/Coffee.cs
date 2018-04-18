using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.TemplateMethodDemo
{
    public class Coffee : CaffeineBeverage
    {
        internal override void AddCondiments()
        {
            Console.WriteLine("加入奶糖");
        }

        internal override void Brew()
        {
            Console.WriteLine("加入咖啡");
        }
    }
}

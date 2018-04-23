using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.CompoundPatternDemo.Entity
{
    public class DuckCall : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("鸭鸣器在叫...");
        }
    }
}

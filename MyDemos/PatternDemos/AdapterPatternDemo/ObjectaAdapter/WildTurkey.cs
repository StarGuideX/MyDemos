using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.AdapterPatternDemo.ObjectaAdapter
{
    public class WildTurkey : Turkey
    {
        public void Fly()
        {
            Console.WriteLine("fly a short distance");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble gobble");
        }
    }
}

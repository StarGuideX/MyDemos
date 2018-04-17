using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.AdapterPatternDemo.ObjectaAdapter
{
    public class TurkeyAdapter : Duck
    {
        Turkey _turkey;

        public TurkeyAdapter(Turkey turkey)
        {
            this._turkey = turkey;
        }

        public void Fly()
        {
            _turkey.Fly();
        }

        public void Quack()
        {
            _turkey.Gobble();
        }
    }
}

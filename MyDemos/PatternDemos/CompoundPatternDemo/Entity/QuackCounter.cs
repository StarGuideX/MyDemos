using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.CompoundPatternDemo.Entity
{
    /// <summary>
    /// QuackCounter类为装饰者
    /// </summary>
    public class QuackCounter : IQuackable
    {
        IQuackable _duck;
        private static int _numberOfQuacks;

        public static int NumberOfQuacks
        {
            get
            {
                return _numberOfQuacks;
            }

            set
            {
                _numberOfQuacks = value;
            }
        }

        public QuackCounter(IQuackable duck)
        {
            _duck = duck;
        }

        public void Quack()
        {
            _duck.Quack();
            NumberOfQuacks++;
        }
    }
}

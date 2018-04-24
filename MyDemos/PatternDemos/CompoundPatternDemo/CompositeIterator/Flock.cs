using PatternDemos.CompoundPatternDemo.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.CompoundPatternDemo.CompositeIterator
{
    /// <summary>
    /// 使用组合模式和迭代器模式
    /// </summary>
    public class Flock : IQuackable, IEnumerable
    {
        IQuackable[] quackers;

        public Flock(IQuackable[] quackers)
        {
            this.quackers = quackers;
        }

        public FlockEnum GetEnumerator()
        {
            return new FlockEnum(quackers);
        }

        public void Quack()
        {
            IEnumerator items = quackers.GetEnumerator();

            while (items.MoveNext())
            {
                IQuackable quacker = (IQuackable)items.Current;
                quacker.Quack();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
    }
}

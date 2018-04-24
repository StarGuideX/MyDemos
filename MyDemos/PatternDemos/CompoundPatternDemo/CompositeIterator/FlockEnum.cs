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
    /// 迭代器模式
    /// </summary>
    public class FlockEnum : IEnumerator
    {
        IQuackable[] quackers;
        int index = -1;

        public IQuackable Current
        {
            get
            {
                try
                {
                    return quackers[index];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public FlockEnum(IQuackable[] quackers)
        {
            this.quackers = quackers;
        }

        public bool MoveNext()
        {
            index++;
            return (index < quackers.Count());
            throw new NotImplementedException();
        }

        public void Reset()
        {
            index = -1;
        }
    }
}

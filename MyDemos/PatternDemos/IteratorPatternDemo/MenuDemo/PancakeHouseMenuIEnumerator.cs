using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.IteratorPatternDemo.MenuDemo
{
    public class PancakeHouseMenuIEnumerator : IEnumerator
    {
        MenuItem[] _items;
        int _index = -1;


        public PancakeHouseMenuIEnumerator(MenuItem[] items)
        {
            this._items = items;
        }


        public object Current
        {
            get
            {
                return _items[_index];
            }
        }

        public bool MoveNext()
        {
            _index++;
            return (_index < _items.Length);
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.IteratorPatternDemo.MenuDemo
{
    public class PancakeHouseMenu : IEnumerable
    {
        MenuItem[] _items;
        public PancakeHouseMenu(MenuItem[] items)
        {
            this._items = items;
        }
        //暂不实现
        public void AddItem(MenuItem item)
        {

        }

        public IEnumerator GetEnumerator()
        {
            return new DinerMenuIEnumerator(_items);
        }
    }
}

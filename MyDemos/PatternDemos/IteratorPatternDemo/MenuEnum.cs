using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.IteratorPatternDemo
{
    public class MenuEnum : IEnumerator
    {
        MenuItem[] _menuItems;
        int _index = -1;

        public MenuEnum(MenuItem[] menuItems)
        {
            this._menuItems = menuItems;
        }

        public MenuItem Current
        {
            get
            {
                try
                {
                    return _menuItems[_index];
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

        public bool MoveNext()
        {
            _index++;
            return (_index < _menuItems.Length);
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.IteratorPatternDemo.BuiltIn
{
    public class Menu : IEnumerable
    {
        private MenuItem[] _menuItems;
        public Menu(MenuItem[] menuItems)
        {
            _menuItems = new MenuItem[menuItems.Length];

            for (int i = 0; i < menuItems.Length; i++)
            {
                _menuItems[i] = menuItems[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public MenuEnum GetEnumerator() {
            return new MenuEnum(_menuItems);
        }
    }
}

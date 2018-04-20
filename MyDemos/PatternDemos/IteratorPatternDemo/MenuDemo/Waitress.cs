using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.IteratorPatternDemo.MenuDemo
{
    public class Waitress
    {
        PancakeHouseMenu _pancakeMenu;
        DinerMenu _dinerMenu;

        public Waitress(PancakeHouseMenu _pancakeMenu, DinerMenu _dinerMenu)
        {
            this._pancakeMenu = _pancakeMenu;
            this._dinerMenu = _dinerMenu;
        }

        public void PrintMenu()
        {
            IEnumerator pancakeEnum = _pancakeMenu.GetEnumerator();
            IEnumerator dinerEnum = _dinerMenu.GetEnumerator();
            Console.WriteLine("------pancake------");
            WriteMenu(pancakeEnum);
            Console.WriteLine("------diner------");
            WriteMenu(dinerEnum);
        }

        private void WriteMenu(IEnumerator iEnumerator)
        {
            while (iEnumerator.MoveNext())
            {
                Console.WriteLine(iEnumerator.Current.ToString());
            }
        }
    }
}

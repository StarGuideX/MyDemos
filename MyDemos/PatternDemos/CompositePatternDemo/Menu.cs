using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.CompositePatternDemo
{
    public class Menu : MenuComponent
    {
        IList<MenuComponent> items = new List<MenuComponent>();
        string _name;
        string _description;

        public Menu(string name, string description)
        {
            this._name = name;
            this._description = description;
        }

        public override void Add(MenuComponent menuComponent)
        {
            items.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            items.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int index)
        {
            return items[index];
        }

        public override string GetName()
        {
           return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override void Print()
        {
            base.Print();
            StringBuilder sb = new StringBuilder();
            sb.Append("菜名为" + _name + ";");
            sb.Append("描述为" + _description + "。");
            Console.WriteLine(sb.ToString());
        }
    }
}

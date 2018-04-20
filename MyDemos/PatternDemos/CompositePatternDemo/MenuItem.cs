using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.CompositePatternDemo
{
    public class MenuItem : MenuComponent
    {
        private string _name;
        private string _description;
        private bool _vegetarian;
        private double _price;

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            this._name = name;
            this._description = description;
            this._vegetarian = vegetarian;
            this._price = price;
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override bool IsVegetarian()
        {
            return _vegetarian;
        }

        public override double GetPrice()
        {
            return _price;
        }

        public override void Add(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("菜名为" + _name + ";");
            sb.Append("描述为" + _description + ";");
            sb.Append("素食为" + _vegetarian + ";");
            sb.Append("价格为" + _price + "。");
            Console.WriteLine(sb.ToString());
        }
    }
}

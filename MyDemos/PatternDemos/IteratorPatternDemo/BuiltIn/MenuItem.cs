using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.IteratorPatternDemo.BuiltIn
{
    public class MenuItem
    {
        private string _name;
        private string _description;
        private bool _vegetarian;
        private double _price;

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
        }

        public bool Vegetarian
        {
            get
            {
                return _vegetarian;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
        }

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            this._name = name;
            this._description = description;
            this._vegetarian = vegetarian;
            this._price = price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("菜名为" + _name + ";");
            sb.Append("描述为" + _description + ";");
            sb.Append("素食为" + _vegetarian + ";");
            sb.Append("价格为" + _price + "。");

            return sb.ToString();
        }

    }
}

using PatternDemos.FactoryPatternDemo.Ingredient;
using PatternDemos.FactoryPatternDemo.Ingredient.Impl;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.FactoryPatternDemo.Pizzas
{
    //工厂生产产品。对PizzaStore来说，产品就是Pizza
    public abstract class Pizza
    {
        protected string _name;
        protected Dough _dough;
        protected Sauce _sauce;
        protected Veggie[] _veggies;
        protected Cheese _cheese;
        protected Pepperoni _pepperoni;
        protected Clams _clam;
        protected IList toppings = new ArrayList();

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("350度烤25分钟");
        }

        public virtual void Cut()
        {
            Console.WriteLine("将比萨饼切成对角片");
        }

        public void Box()
        {
            Console.WriteLine("将披萨装在披萨盒里");
        }

        public override string ToString()
        {
            return "";
        }
    }
}

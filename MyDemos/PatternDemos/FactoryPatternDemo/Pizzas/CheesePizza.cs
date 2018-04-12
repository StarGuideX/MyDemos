using PatternDemos.FactoryPatternDemo.IngredientFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PatternDemos.FactoryPatternDemo.Pizzas
{
    public class CheesePizza : Pizza
    {
        PizzaIngredientFactory _ingredientFactory;

        public CheesePizza(PizzaIngredientFactory ingredientFactory)
        {
            this._ingredientFactory = ingredientFactory;
        }

        //披萨获取原料
        //获取工厂的原料，不在乎是什么工厂
        //Create会返回你需要的哪个工厂的哪个原料
        public override void Prepare()
        {
            Console.WriteLine("准备 " + _name);
            _dough = _ingredientFactory.CreateDough();
            _sauce = _ingredientFactory.CreateSauce();
            _cheese = _ingredientFactory.CreateCheese();
            
        }


        //public CheesePizza()
        //{
        //    _name = "纽约披萨";
        //    _dough = "薄饼";
        //    _sauce = "大蒜蕃茄酱";

        //    toppings.Add("意大利Regginao高级干酪");
        //}
    }
}

using PatternDemos.FactoryPatternDemo.IngredientFactory;
using PatternDemos.FactoryPatternDemo.Pizzas;

namespace PatternDemos.FactoryPatternDemo.Store
{
    public class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if (type.Equals("Cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "纽约披萨";
            }
            else if (type.Equals("Clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.Name = "蛤蜊披萨";
            }
            return pizza;
        }
    }
}

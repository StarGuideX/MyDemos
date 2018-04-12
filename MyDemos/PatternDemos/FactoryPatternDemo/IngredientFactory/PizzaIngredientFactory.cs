using PatternDemos.FactoryPatternDemo.Ingredient;
using PatternDemos.FactoryPatternDemo.Ingredient.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.FactoryPatternDemo.IngredientFactory
{
    public interface PizzaIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
        Veggie[] CreateVeggies();
        Pepperoni CreatePepperoni();
        Clams CreateClam();

    }
}

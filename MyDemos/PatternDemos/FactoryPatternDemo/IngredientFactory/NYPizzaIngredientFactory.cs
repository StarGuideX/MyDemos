using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternDemos.FactoryPatternDemo.Ingredient;
using PatternDemos.FactoryPatternDemo.Ingredient.Impl;

namespace PatternDemos.FactoryPatternDemo.IngredientFactory
{
    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public Clams CreateClam()
        {
            return new FreshClams();
        }

        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public Veggie[] CreateVeggies()
        {
            Veggie[] veggies = { new Garlic(), new Onion() };
            return veggies;
        }
    }
}

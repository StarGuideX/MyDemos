using PatternDemos.FactoryPatternDemo.Pizzas;

namespace PatternDemos.FactoryPatternDemo.Store
{
    //创建者类，定义了一个抽象的工厂方法，让子类实现此方法制造产品。
    //创建者通常会包含依赖于抽象产品的代码，而这些抽象产品由子类制造，创建者不需要真的知道在制造哪种具体产品。
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza;

            pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        //工厂方法，用来制造产品
        //因为每个加盟店都有自己的PizzaStore子类，所以可以利用实现此方法创建自己风味的披萨
        protected  abstract Pizza CreatePizza(string type);
    }
}

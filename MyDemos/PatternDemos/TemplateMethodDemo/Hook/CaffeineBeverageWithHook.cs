using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.TemplateMethodDemo.Hook
{
    public abstract class CaffeineBeverageWithHook
    {
        internal void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        //子类必须实现
        internal abstract void Brew();

        //子类必须实现
        internal abstract void AddCondiments();

        //子类可以重写
        internal virtual void BoilWater()
        {
            Console.WriteLine("煮水");
        }

        internal virtual void PourInCup()
        {
            Console.WriteLine("倒入杯中");
        }

        internal virtual bool CustomerWantsCondiments()
        {
            return true;
        }
    }
}

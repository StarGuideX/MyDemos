using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.AdapterPatternDemo.ClassAdapter
{
    public class TurkeyAdapter : WildTurkey, Duck
    {
        //因为火鸡和鸭子都能fly，所以写成这种模式，或许不写，也能行通
        public new void Fly()
        {
            //使用火鸡的Fly
            base.Fly();
        }
        //这个方法是正宗的
        public void Quack()
        {
            //使用火鸡的Gobble
            base.Gobble();
        }
    }
}

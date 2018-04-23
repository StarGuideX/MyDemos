using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.StatePatternDemo
{
    public class SoldOutState : State
    {
        GumballMachine _machine;

        public SoldOutState(GumballMachine machine)
        {
            _machine = machine;
        }

        public void Dispense()
        {
            Console.WriteLine("卖光了，不能分配");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("卖光了，不能退钱");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("卖光了，不能付钱");
        }

        public void TurnCrank()
        {
            Console.WriteLine("卖光了，不能给你糖果");
        }
    }
}

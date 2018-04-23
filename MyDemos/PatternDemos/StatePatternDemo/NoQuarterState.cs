using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.StatePatternDemo
{
    public class NoQuarterState : State
    {
        GumballMachine _machine;

        public NoQuarterState(GumballMachine machine)
        {
            _machine = machine;
        }

        public void Dispense()
        {
            Console.WriteLine("你需要付钱");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("你没付钱，不能退款");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("你付款了，机器正在改变状态");
            _machine.State = _machine.HasQuarterState;
        }

        public void TurnCrank()
        {
            Console.WriteLine("你没付钱，不可能给你糖果");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.StatePatternDemo
{
    public class SoldState : State
    {
        GumballMachine _machine;

        public SoldState(GumballMachine machine)
        {
            _machine = machine;
        }

        public void Dispense()
        {
            Console.WriteLine("正在出糖果");
            if (_machine.Count == 0)
            {
                Console.WriteLine("最后一个了");
                _machine.State = _machine.SoldOutState; 
            }
            else
            {
                _machine.State = _machine.NoQuarterState;
            }
        }

        public void EjectQuarter()
        {
            Console.WriteLine("已经转动了曲柄，就不能退钱了");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("稍后会给你一个糖果");
        }

        public void TurnCrank()
        {
            Console.WriteLine("别想骗过机器拿两次糖果");
        }
    }
}

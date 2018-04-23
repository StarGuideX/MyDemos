using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.StatePatternDemo
{
    public class HasQuarterState : State
    {
        GumballMachine _machine;
        Random randomWinner = new Random(9);

        public HasQuarterState(GumballMachine machine)
        {
            _machine = machine;
        }

        public void Dispense()
        {
            Console.WriteLine("无糖果分配");
        }

        public void EjectQuarter()
        {
            _machine.State = _machine.NoQuarterState;
            Console.WriteLine("退钱完毕");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("不能再继续放入钱");
        }

        public void TurnCrank()
        {
            _machine.State = _machine.SoldState;
            Console.WriteLine("正在出糖果");

            int winner = randomWinner.Next(10);
            if (winner == 0 && _machine.Count > 2)
            {
                _machine.State = _machine.WinnerState;
            }
            else
            {
                _machine.State = _machine.SoldState;
            }
        }
    }
}

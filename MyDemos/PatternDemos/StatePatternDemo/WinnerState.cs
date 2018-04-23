using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.StatePatternDemo
{
public class WinnerState : State
{
    GumballMachine _machine;

    public WinnerState(GumballMachine machine)
    {
        _machine = machine;
    }

    public void Dispense()
    {
        Console.WriteLine("你是赢家，你使用25美分拿出了2个糖果");
        _machine.ReleaseBall();
        if (_machine.Count == 0)
        {
            _machine.State = _machine.SoldOutState;
        }
        else {
            _machine.ReleaseBall();
            if (_machine.Count > 0)
            {
                _machine.State = _machine.NoQuarterState;
            }
            else {
                _machine.State = _machine.SoldOutState;
            }
        }

    }

    public void EjectQuarter()
    {
        Console.WriteLine("不能退款");
    }

    public void InsertQuarter()
    {
        Console.WriteLine("你已经付钱了");
    }

    public void TurnCrank()
    {
        Console.WriteLine("你已经转动过了");
    }
}
}

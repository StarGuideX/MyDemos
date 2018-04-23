using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.StatePatternDemo
{
    public class GumballMachine
    {
        private State _soldOutState;
        private State _noQuarterState;
        private State _hasQuarterState;
        private State _soldState;
        private State _WinnerState;
        private State _state;

        private int _count = 0;

        public State State { get => _state; set => _state = value; }
        public State SoldOutState { get => _soldOutState; set => _soldOutState = value; }
        public State NoQuarterState { get => _noQuarterState; set => _noQuarterState = value; }
        public State HasQuarterState { get => _hasQuarterState; set => _hasQuarterState = value; }
        public State SoldState { get => _soldState; set => _soldState = value; }

        public int Count { get => _count; set => _count = value; }
        public State WinnerState { get => _WinnerState; set => _WinnerState = value; }

        public GumballMachine(int count)
        {
            _state = _soldOutState;
            SoldOutState = new SoldOutState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);
            WinnerState = new WinnerState(this);
            this.Count = count;
            if (Count > 0)
            {
                State = NoQuarterState;
            }
        }

        //放入25美分
        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }
        //退款
        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }
        //转动摇杆获取糖果
        public void TurnCrank()
        {
            _state.TurnCrank();
            _state.Dispense();
        }
        
        public void ReleaseBall()
        {
            Console.WriteLine("");
            if (_count != 0)
            {
                _count = _count - 1;
            }
        }
    }
}

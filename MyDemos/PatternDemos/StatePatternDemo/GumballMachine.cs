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

        public State SoldOutState
        {
            get
            {
                return _soldOutState;
            }

            set
            {
                _soldOutState = value;
            }
        }

        public State NoQuarterState
        {
            get
            {
                return _noQuarterState;
            }

            set
            {
                _noQuarterState = value;
            }
        }

        public State HasQuarterState
        {
            get
            {
                return _hasQuarterState;
            }

            set
            {
                _hasQuarterState = value;
            }
        }

        public State SoldState
        {
            get
            {
                return _soldState;
            }

            set
            {
                _soldState = value;
            }
        }

        public State WinnerState
        {
            get
            {
                return _WinnerState;
            }

            set
            {
                _WinnerState = value;
            }
        }

        public State State
        {
            get
            {
                return _state;
            }

            set
            {
                _state = value;
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }

            set
            {
                _count = value;
            }
        }

        public GumballMachine(int count)
        {
            State = SoldOutState;
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
            State.InsertQuarter();
        }
        //退款
        public void EjectQuarter()
        {
            State.EjectQuarter();
        }
        //转动摇杆获取糖果
        public void TurnCrank()
        {
            State.TurnCrank();
            State.Dispense();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("");
            if (Count != 0)
            {
                Count = Count - 1;
            }
        }
    }
}

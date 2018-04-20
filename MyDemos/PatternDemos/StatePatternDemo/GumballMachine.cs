using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.StatePatternDemo
{
    public class GumballMachine
    {
        public enum StateType
        {
            SOLD_OUT,
            NO_QUARTER,
            HAS_QUARTER,
            SOLD
        }

        private StateType _state = StateType.SOLD_OUT;
        private int _count = 0;

        public GumballMachine(int count)
        {
            this._count = count;
            if (_count > 0)
            {
                _state = StateType.NO_QUARTER;
            }
        }

        public void InsertQuarter()
        {
            switch (_state)
            {
                case StateType.SOLD_OUT:
                    Console.WriteLine("不能再继续放入25美分，卖光了");
                    break;
                case StateType.NO_QUARTER:
                    _state = StateType.HAS_QUARTER;
                    Console.WriteLine("放入了25美分");
                    break;
                case StateType.HAS_QUARTER:
                    Console.WriteLine("不能再继续放入25美分");
                    break;
                case StateType.SOLD:
                    Console.WriteLine("稍后会给你一个糖果");
                    break;
                default:
                    break;
            }
        }

        public void EjectQuarter()
        {
            switch (_state)
            {
                case StateType.SOLD_OUT:
                    Console.WriteLine("糖果卖光了，没有接受25美分，也不可能退钱");
                    break;
                case StateType.NO_QUARTER:
                    Console.WriteLine("没有25美分，也不可能退钱");
                    break;
                case StateType.HAS_QUARTER:
                    _state = StateType.NO_QUARTER;
                    Console.WriteLine("正在退钱");
                    break;
                case StateType.SOLD:
                    Console.WriteLine("已经转动了曲柄，就不能退钱了");
                    break;
                default:
                    break;
            }
        }

        public void TurnCrank()
        {
            switch (_state)
            {
                case StateType.SOLD_OUT:
                    Console.WriteLine("糖果卖光了");
                    break;
                case StateType.NO_QUARTER:
                    Console.WriteLine("需要先放入25美分");
                    break;
                case StateType.HAS_QUARTER:
                    _state = StateType.SOLD;
                    dispense();
                    Console.WriteLine("正在出糖果");
                    break;
                case StateType.SOLD:
                    Console.WriteLine("别想骗过机器拿两次糖果");
                    break;
                default:
                    break;
            }
        }

        private void dispense()
        {
            switch (_state)
            {
                case StateType.SOLD_OUT:
                    Console.WriteLine("无糖果");
                    break;
                case StateType.NO_QUARTER:
                    Console.WriteLine("无糖果");
                    break;
                case StateType.HAS_QUARTER:
                    Console.WriteLine("无糖果");
                    break;
                case StateType.SOLD:
                    Console.WriteLine("正在出糖果");
                    _count = _count - 1;
                    if (_count == 0)
                    {
                        Console.WriteLine("最后一个了");
                        _state = StateType.SOLD_OUT;
                    }
                    else
                    {
                        _state = StateType.NO_QUARTER;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}

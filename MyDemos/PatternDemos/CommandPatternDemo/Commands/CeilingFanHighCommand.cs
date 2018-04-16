using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.CommandPatternDemo.Commands
{
    public class CeilingFanHighCommand : Command
    {
        CeilingFan _ceilingFan;
        int _preSpeed;

        public CeilingFanHighCommand(CeilingFan cf) {
            this._ceilingFan = cf;
        }

        public void Execute()
        {
            _preSpeed = _ceilingFan.GetSpeed();
            _ceilingFan.High();
            Console.WriteLine("High_Excecute...");
        }

        public void Undo()
        {
            switch (_preSpeed)
            {
                case (int)CeilingFan.CeilingFanType.HIGH:
                    _ceilingFan.High();
                    break;
                case (int)CeilingFan.CeilingFanType.MEDIUM:
                    _ceilingFan.Medium();
                    break;
                case (int)CeilingFan.CeilingFanType.LOW:
                    _ceilingFan.Low();
                    break;
                case (int)CeilingFan.CeilingFanType.OFF:
                    _ceilingFan.Off();
                    break;
                default:
                    break;
            }
        }
    }
}

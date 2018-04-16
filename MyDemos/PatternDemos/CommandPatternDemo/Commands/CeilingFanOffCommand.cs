using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.CommandPatternDemo.Commands
{
    public class CeilingFanOffCommand : Command
    {
        CeilingFan _ceilingFan;
        int _preSpeed;

        public CeilingFanOffCommand(CeilingFan cf) {
            this._ceilingFan = cf;
        }

        public void Execute()
        {
            _preSpeed = _ceilingFan.GetSpeed();
            _ceilingFan.Off();
            Console.WriteLine("Off_Excecute...");
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

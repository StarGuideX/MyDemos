using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.CommandPatternDemo.Commands
{
    public class LightOnCommand : Command
    {
        Light _light;
        public LightOnCommand(Light light)
        {
            this._light = light;
        }
        public void Execute()
        {
            _light.On();
        }

        public void Undo()
        {
            _light.Off();
        }
    }
}

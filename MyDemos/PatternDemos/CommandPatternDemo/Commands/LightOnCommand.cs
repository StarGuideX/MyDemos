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
        //执行命令
        public void Execute()
        {
            _light.On();
        }
        //撤销
        public void Undo()
        {
            _light.Off();
        }
    }
}

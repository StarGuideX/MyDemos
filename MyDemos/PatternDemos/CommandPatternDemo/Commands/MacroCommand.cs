using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.CommandPatternDemo.Commands
{
    public class MacroCommand : Command
    {
        Command[] _commands;

        public MacroCommand(Command[] commands)
        {
            this._commands = commands;
        }

        public void Execute()
        {
            foreach (var item in _commands)
            {
                item.Execute();
            }
        }

        public void Undo()
        {
            foreach (var item in _commands)
            {
                item.Undo();
            }
        }
    }
}

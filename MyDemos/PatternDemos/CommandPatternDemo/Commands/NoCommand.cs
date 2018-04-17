using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.CommandPatternDemo.Commands
{
    public class NoCommand : Command
    {
        public void Execute()
        {
        }

        public void Undo()
        {
        }
    }
}

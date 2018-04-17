using PatternDemos.CommandPatternDemo.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.CommandPatternDemo
{
    public class RemoteControl
    {
        Command[] _onCommands;
        Command[] _offCommands;
        Command undoCommand;
        public RemoteControl()
        {
            _onCommands = new Command[7];
            _offCommands = new Command[7];
            //创建空命令
            Command nc = new NoCommand();
            for (int i = 0; i < _onCommands.Count(); i++)
            {
                _onCommands[i] = nc;
                _offCommands[i] = nc;
            }
            undoCommand = nc;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="slot">插槽位置</param>
        /// <param name="onCommand">开的命令</param>
        /// <param name="offCommand">关的命令</param>
        public void SetCommand(int slot, Command onCommand, Command offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }
        //按下开，执行
        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].Execute();
            undoCommand = _onCommands[slot];
        }
        //按下关，执行
        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].Execute();
            undoCommand = _offCommands[slot];
        }
        //撤销按钮
        public void UndoButtonWasPushed()
        {
            undoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n------ Remote Control ------\n");
            int slot = 0;

            foreach (var item in _onCommands)
            {
                if (item != null)
                {
                    sb.Append(@"[ slot " + slot + "] " + _onCommands[slot].GetType().Name + "    " + _offCommands[slot].GetType().Name + "\n");
                    slot++;
                }
            }
            return sb.ToString();
        }
    }
}

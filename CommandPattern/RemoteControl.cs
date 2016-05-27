using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class RemoteControl
    {
        ICommand[] _onCommands;
        ICommand[] _offCommands;

        ICommand _undoCommand;

        public RemoteControl()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            var noCommand = new NoCommand();

            for (int i = 0; i < 7; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }

            _undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void PressOnButton(int slot)
        {
            _onCommands[slot].Execute();

            _undoCommand = _onCommands[slot];
        }

        public void PressOffButton(int slot)
        {
            _offCommands[slot].Execute();

            _undoCommand = _offCommands[slot];
        }

        public void PressUndoButton()
        {
            _undoCommand.Undo();
        }

        public override string ToString()
        {
            var info = new StringBuilder("------- Remote Control -------");

            for (int i = 0; i < 7; i++)
            {
                info.AppendFormat("\nSlot {0} = {1} / {2}", i, _onCommands[i].GetType(), _offCommands[i].GetType());
            }

            info.AppendLine();

            return info.ToString();
        }
    }
}

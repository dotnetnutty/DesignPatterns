using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class SimpleRemoteControl
    {
        ICommand _slot;

        public SimpleRemoteControl()
        {
        }

        public void SetCommand(ICommand command)
        {
            _slot = command;
        }

        public void PressButton()
        {
            _slot.Execute();
        }
    }
}

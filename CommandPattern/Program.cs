using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var remoteControl = new RemoteControl();

            var ceilingFan = new CeilingFan("Living room");
            var ceilingFanLowCommand = new CeilingFanLowCommand(ceilingFan);
            var ceilingFanMediumCommand = new CeilingFanMediumCommand(ceilingFan);
            var ceilingFanHighCommand = new CeilingFanHighCommand(ceilingFan);
            var ceilingFanOffCommand = new CeilingFanOffCommand(ceilingFan);

            remoteControl.SetCommand(0, ceilingFanMediumCommand, ceilingFanOffCommand);
            remoteControl.SetCommand(1, ceilingFanHighCommand, ceilingFanOffCommand);

            remoteControl.PressOnButton(0);
            remoteControl.PressOffButton(0);

            Console.WriteLine(remoteControl);

            remoteControl.PressUndoButton();

            remoteControl.PressOnButton(1);
            Console.WriteLine(remoteControl);
            remoteControl.PressUndoButton();
        }
    }
}
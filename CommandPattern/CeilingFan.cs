using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class CeilingFan
    {
        public CeilingFanSpeed Speed { get; set; }

        string _description;

        public CeilingFan( string description )
        {
            _description = description;
            Speed = CeilingFanSpeed.Off;
        }

        public void High()
        {
            Speed = CeilingFanSpeed.High;
            Console.WriteLine(_description + " fan is now high");
        }

        public void Medium()
        {
            Speed = CeilingFanSpeed.Medium;
            Console.WriteLine(_description + " fan is now medium");
        }

        public void Low()
        {
            Speed = CeilingFanSpeed.Low;
            Console.WriteLine(_description + " fan is now low");
        }

        public void Off()
        {
            Speed = CeilingFanSpeed.Off;
            Console.WriteLine(_description + " fan is now off");
        }
    }
}

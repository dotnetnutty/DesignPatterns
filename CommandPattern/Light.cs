using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Light
    {
        string _description;

        public Light(string description)
        {
            _description = description;
        }

        public void On()
        {
            Console.WriteLine(_description + " light is now on");
        }

        public void Off()
        {
            Console.WriteLine(_description + " light is now off");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class SoldOutState : IState
    {
        GumballMachine _gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("SOS: No gumballs to dispense");        }

        public void EjectQuarter()
        {
            Console.WriteLine("SOS: No quarter to eject");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("SOS: You can't insert a quarter; we're sold out");
        }

        public void TurnCrank()
        {
            Console.WriteLine("SOS: You turned, but there are no gumballs");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class HasQuarterState : IState
    {
        GumballMachine _gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("HQS: No gumball dispensed; you haven't turned the crank!");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("HQS: Quarter returned...");
            _gumballMachine.SetState(_gumballMachine.NoQuarterState);
        }

        public void InsertQuarter()
        {
            Console.WriteLine("HQS: You can't insert another quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("HQS: You turned the crank...");

            Random randomNumber = new Random(DateTime.Now.Millisecond);
            int winner = randomNumber.Next(10);

            if (winner == 0 && _gumballMachine.Count > 1)
            {
                _gumballMachine.SetState(_gumballMachine.WinnerState);
            }
            else
            {
                _gumballMachine.SetState(_gumballMachine.SoldState);
            }
        }
    }
}

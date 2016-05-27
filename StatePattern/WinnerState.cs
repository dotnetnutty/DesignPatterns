using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class WinnerState : IState
    {
        GumballMachine _gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("WS: WINNER!");

            _gumballMachine.ReleaseBall();

            if (_gumballMachine.Count == 0)
            {
                _gumballMachine.SetState(_gumballMachine.SoldOutState);
            }
            else
            {
                _gumballMachine.ReleaseBall();

                if (_gumballMachine.Count == 0)
                {
                    _gumballMachine.SetState(_gumballMachine.SoldOutState);
                }
                else
                {
                    _gumballMachine.SetState(_gumballMachine.NoQuarterState);
                }
            }
        }

        public void EjectQuarter()
        {
            Console.WriteLine("WS: Too late to eject!");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("WS: Please wait. We're already giving you a gumball.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("WS: Turning again doesn't get you another gumball!");
        }
    }
}

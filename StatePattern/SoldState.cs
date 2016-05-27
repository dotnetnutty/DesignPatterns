using System;

namespace ConsoleApplication1
{
    public class SoldState : IState
    {
        GumballMachine _gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("SS: Dispensing");

            _gumballMachine.ReleaseBall();

            if (_gumballMachine.Count > 0)
            {
                _gumballMachine.SetState(_gumballMachine.NoQuarterState);
            }
            else
            {
                _gumballMachine.SetState(_gumballMachine.SoldOutState);
            }
        }

        public void EjectQuarter()
        {
            Console.WriteLine("SS: Too late to eject!");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("SS: Please wait. We're already giving you a gumball.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("SS: Turning twice doesn't get you another gumball!");
        }
    }
}

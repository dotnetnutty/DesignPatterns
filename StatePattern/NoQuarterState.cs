using System;

namespace ConsoleApplication1
{
    public class NoQuarterState : IState
    {
        GumballMachine _gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("NQS: You need to pay first!");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("NQS: You haven't inserted a quarter!");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("NQS: Thank you for inserting a quarter!");
            _gumballMachine.SetState(_gumballMachine.HasQuarterState);
        }

        public void TurnCrank()
        {
            Console.WriteLine("NQS: Nice try... you haven't inserted a quarter yet!");
        }
    }
}

using System;
using System.Text;

namespace ConsoleApplication1
{
    public class GumballMachine
    {
        public IState SoldOutState;
        public IState NoQuarterState;
        public IState HasQuarterState;
        public IState SoldState;
        public IState WinnerState;

        IState _state;

        public int Count { get; set; }

        public GumballMachine(int numberOfGumballs)
        {
            Count = numberOfGumballs;

            SoldOutState = new SoldOutState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);
            WinnerState = new WinnerState(this);

            if (numberOfGumballs>0)
            {
                _state = NoQuarterState;
            }
            else
            {
                _state = SoldOutState;
            }
        }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        public void TurnCrank()
        {
            _state.TurnCrank();
            _state.Dispense();
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("GBM: A gumball comes rolling out the slot...");

            if (Count != 0)
            {
                Count--;
            }
        }

        public override string ToString()
        {
            var intro = new StringBuilder();
            intro.AppendLine("*** SCAMP GUMBALLS ***");
            intro.AppendLine("**********************");
            intro.AppendFormat("Inventory: {0} gumballs", Count);

            return intro.ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var turkey = new WildTurkey();
            var turkeyAdapter = new TurkeyAdapter(turkey);

            turkeyAdapter.Fly();
            turkeyAdapter.Quack();
        }
    }
}

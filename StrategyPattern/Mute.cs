using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class Mute : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("...[silence]");
        }
    }
}

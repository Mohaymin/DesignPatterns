using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class Mute : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("...[silence]");
        }
    }
}

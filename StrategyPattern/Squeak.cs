using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class Squeak : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeak! Squeak!!");
        }
    }
}

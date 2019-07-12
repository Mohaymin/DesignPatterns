using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class CanFly : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying hihg!");
        }
    }
}

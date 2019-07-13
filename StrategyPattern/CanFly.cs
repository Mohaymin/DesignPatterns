using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class CanFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying hihg!");
        }
    }
}

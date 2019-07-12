using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class CanNotFly : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I can not fly");
        }
    }
}

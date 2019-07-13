using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class CanNotFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can not fly");
        }
    }
}

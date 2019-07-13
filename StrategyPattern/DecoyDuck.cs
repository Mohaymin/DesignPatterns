using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class DecoyDuck : Duck
    {
        public DecoyDuck() : base()
        {
            AssignFlyBehavior();
            AssignQuackBehavior();
        }
        public override void AssignFlyBehavior()
        {
            flyBehavior = new CanNotFly();
        }

        public override void AssignQuackBehavior()
        {
            quackBehavior = new Mute();
        }
        public override string ToString()
        {
            return "I am the Decoy Duck";
        }
    }
}

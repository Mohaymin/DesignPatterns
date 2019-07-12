using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class DecoyDuck : Duck
    {
        public DecoyDuck() : base()
        {
            assignFlyBehavior();
            assignQuackBehavior();
        }
        public override void assignFlyBehavior()
        {
            flyBehavior = new CanNotFly();
        }

        public override void assignQuackBehavior()
        {
            quackBehavior = new Mute();
        }
        public override string ToString()
        {
            return "I am the Decoy Duck";
        }
    }
}

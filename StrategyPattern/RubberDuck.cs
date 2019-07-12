using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class RubberDuck : Duck
    {
        public RubberDuck() : base()
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
            quackBehavior = new Squeak();
        }
        public override string ToString()
        {
            return "I'm a Rubber Duck";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class RubberDuck : Duck
    {
        public RubberDuck() : base()
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
            quackBehavior = new Squeak();
        }
        public override string ToString()
        {
            return "I'm a Rubber Duck";
        }
    }
}

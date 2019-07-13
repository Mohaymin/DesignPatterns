using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class MallardDuck : Duck
    {
        public MallardDuck() : base()
        {
            AssignFlyBehavior();
            AssignQuackBehavior();
        }

        public override void AssignFlyBehavior()
        {
            flyBehavior = new CanFly();
        }

        public override void AssignQuackBehavior()
        {
            quackBehavior = new Quack();
        }
        public override string ToString()
        {
            return "I am Mallard Duck";
        }
    }
}

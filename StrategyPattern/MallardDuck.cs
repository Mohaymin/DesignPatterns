using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class MallardDuck : Duck
    {
        public MallardDuck() : base()
        {
            assignFlyBehavior();
            assignQuackBehavior();
        }

        public override void assignFlyBehavior()
        {
            flyBehavior = new CanFly();
        }

        public override void assignQuackBehavior()
        {
            quackBehavior = new Quack();
        }
        public override string ToString()
        {
            return "I am Mallard Duck";
        }
    }
}

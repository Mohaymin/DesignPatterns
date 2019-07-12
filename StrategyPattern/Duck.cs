using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public abstract class Duck
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;

        public void swim()
        {
            Console.WriteLine("I'm swimming!");
        }
        public abstract void assignFlyBehavior();
        public abstract void assignQuackBehavior();

        public void tryToFly()
        {
            flyBehavior.fly();
        }
        public void makeSound()
        {
            quackBehavior.quack();
        }
    }
}

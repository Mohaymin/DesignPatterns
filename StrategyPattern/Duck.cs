using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public abstract class Duck
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;

        public void Swim()
        {
            Console.WriteLine("I'm swimming!");
        }

        /*
         * The following two abstract classes
         * forces the programmer to initialize
         * IFlyBehavior and IQuackBehavior.
         * Note that if these two variables are un-initialized
         * we will get null pointer exception error
         */
        public abstract void AssignFlyBehavior();
        public abstract void AssignQuackBehavior();

        public void TryToFly()
        {
            flyBehavior.Fly();
        }
        public void MakeSound()
        {
            quackBehavior.Quack();
        }
    }
}

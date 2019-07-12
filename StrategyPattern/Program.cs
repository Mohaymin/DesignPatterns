using System;

namespace StrategyPattern
{
    class Program
    {
        private static void displayProperties(Duck duck)
        {
            Console.WriteLine(duck);
            duck.swim();
            duck.tryToFly();
            duck.makeSound();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("These three ducks may give you a good day!\n");
            Duck duck1 = new MallardDuck();
            Duck duck2 = new RubberDuck();
            Duck duck3 = new DecoyDuck();

            displayProperties(duck1);
            displayProperties(duck2);
            displayProperties(duck3);

            Console.ReadLine();
        }

    }
}

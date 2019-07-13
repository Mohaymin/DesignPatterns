using System;

namespace StrategyPattern
{
     //This is the class where we test our program
    class Program
    {
        private static void DisplayProperties(Duck duck)
        {
            Console.WriteLine(duck);
            duck.Swim();
            duck.TryToFly();
            duck.MakeSound();
            Console.WriteLine();
        }
         
        static void Main(string[] args)
        {
            Console.WriteLine("These three ducks may give you a good day!\n");
            Duck duck1 = new MallardDuck();
            Duck duck2 = new RubberDuck();
            Duck duck3 = new DecoyDuck();

            DisplayProperties(duck1);
            DisplayProperties(duck2);
            DisplayProperties(duck3);

            Console.ReadLine();
        }
    }
}

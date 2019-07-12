﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class Quack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack! Quack!!");
        }
    }
}

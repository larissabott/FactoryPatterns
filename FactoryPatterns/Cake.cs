using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatterns
{
    class Cake : IBakedGoods
    {
        public string Flavor { get; set; }
        public bool IsEdible { get; set; }
        public void Bake()
        {
            Console.WriteLine($"Oops! Not preheated yet, come back soon to bake a {Flavor} cake.");
        }
    }
}

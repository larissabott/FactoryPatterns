using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatterns
{
    class Muffin : IBakedGoods 
    {
        public string Flavor { get; set; }
        public string filling { get; set; }
        public void Bake()
        {
            Console.WriteLine("Making a muffin");
        }
    }
}

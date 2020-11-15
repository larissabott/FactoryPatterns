using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatterns
{
    class BakedGoodsFactory
    {
        public IBakedGoods CreateBakedGoods(string userInput)
        {
            switch (userInput.ToLower())
            {
                case "cake":
                    return new Cake() {Flavor = "Chocolate", IsEdible = true };
                case "muffin":
                    return new Muffin();
                default:
                    return new Cake();
            }
        }
    }
}

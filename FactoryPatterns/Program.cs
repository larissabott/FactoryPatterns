using System;

namespace FactoryPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of baked goods do you want to make? Cake or Muffin??");
            string userInput = Console.ReadLine();

            BakedGoodsFactory factory = new BakedGoodsFactory();
            IBakedGoods myBakedGoods = factory.CreateBakedGoods(userInput);

            myBakedGoods.Bake();

            Console.WriteLine("Lets make more baked Goods");
            userInput = Console.ReadLine();
        }
    }
}

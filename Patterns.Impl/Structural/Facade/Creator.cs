using System;

namespace Patterns.Impl.Structural.Facade
{
    public class Creator
    {
        public Gift MakeGift(string discription)
        {
            Console.WriteLine($"Сделали подарок по заказу: \"{discription}\"");

            var gift = new Gift() { Size = 100 };

            return gift;
        }
    }
}

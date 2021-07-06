using System;

namespace Patterns.Impl.Structural.Facade
{
    public class Packer
    {
        public Gift MakeBeautifulCover(Gift gift)
        {
            gift.IsPacked = true;

            Console.WriteLine($"Объект размером {gift.Size} красиво упаковали, и сбоку бантик");

            return gift;
        }
    }
}

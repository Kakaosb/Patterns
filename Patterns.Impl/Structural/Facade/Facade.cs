using System;

namespace Patterns.Impl.Structural.Facade
{
    public class Facade
    {
        protected Creator _creator;
        protected Packer _packer;

        public Facade(Creator creator, Packer packer)
        {
            _creator = creator;
            _packer = packer;
        }

        public Gift GetGift()
        {
            Console.WriteLine("Клиент захотел красвио упакованный подарочек");
            
            var gift = _creator.MakeGift("Что-то необычное, словно уточка в красных штанишках");

            var packedGift = _packer.MakeBeautifulCover(gift);

            return packedGift;
        }
    }
}

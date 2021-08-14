using Patterns.Def.Behavior.Mediator;
using System;

namespace Patterns.Impl.Behavior.Mediator
{
   public class ConcreteMediator : IMediator
    {
        private Egg _egg;

        private Salt _salt;

        public ConcreteMediator(Egg egg, Salt salt)
        {
            this._egg = egg;
            this._egg.SetMediator(this);
            this._salt = salt;
            this._salt.SetMediator(this);
        }

        public void Notify(object sender, string ev)
        {
            if (ev == "L_E")
            {
                Console.WriteLine("Mediator reacts on L_E and triggers folowing operations:");
                this._salt.Location();
            }
            if (ev == "S_F")
            {
                Console.WriteLine("Mediator reacts on S_F and triggers following operations:");
                this._egg.Coocking();
                this._salt.Location();
            }
        }
    }
}

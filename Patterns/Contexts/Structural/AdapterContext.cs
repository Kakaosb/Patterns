using Patterns.Def.Structural.Adapter;
using Patterns.Impl.Structural.Adapter;
using System;

namespace Patterns.Contexts
{
    public class AdapterContext : IContext
    {
        public void Excecute()
        {
            Alien alien = new Alien();
            ISoundReproductor reproductor = new AlienSoundReproductor(alien);

            Console.WriteLine("Мы не можем понять, что говорит пришелец в ответ на наше приветствие");
            Console.WriteLine("Но адаптер преобразует звуки в понятную нам речь");

            Console.WriteLine();
            reproductor.TranslateSound();

            Console.WriteLine();
        }
    }
}
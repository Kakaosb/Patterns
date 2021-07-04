using Patterns.Def.Structural.Adapter;
using System;

namespace Patterns.Impl.Structural.Adapter
{
    public class AlienSoundReproductor : ISoundReproductor
    {
        private readonly Alien _alien;

        public AlienSoundReproductor(Alien alien) {
            _alien = alien;
        }

        public void TranslateSound()
        {
            //трансляция сказанного на человеко-понятном языке
           Console.WriteLine($"Перевожу на человеко-понятный: {_alien.SayHello()}");
        }
    }
}
using Patterns.Impl.Behavior.Fluent_Builder;
using System;

namespace Patterns.Contexts
{
    class FluentBuilderContext : IContext
    {
        public void Excecute()
        {
            User tom = new UserBuilder().SetName("Tom").SetCompany("Microsoft").SetAge(23);
            User alice = User.CreateBuilder().SetName("Alice").IsMarried.SetAge(25);

            Console.WriteLine();
        }
    }
}

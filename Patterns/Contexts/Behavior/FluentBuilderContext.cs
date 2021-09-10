using Patterns.Impl.Behavior.Fluent_Builder;
using System;

namespace Patterns.Contexts
{
    class FluentBuilderContext : IContext
    {
        public void Excecute()
        {
            User user1 = new UserBuilder().SetName("Tom").SetCompany("Microsoft").SetAge(23);
            User user2 = User.CreateBuilder().SetName("Alice").IsMarried.SetAge(25);

            user1.ShowInfo();
            user2.ShowInfo();
        }
    }
}

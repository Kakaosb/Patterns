using System;

namespace Patterns.Impl.Behavior.Fluent_Builder
{
    public class User
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public int Age { get; set; }
        public bool IsMarried { get; set; }

        public static UserBuilder CreateBuilder()
        {
            return new UserBuilder();
        }
    }

    public static class UserExtension
    {
        public static void ShowInfo(this User user)
        {
            Console.WriteLine($"User info. Name: {user.Name}, Company: {user.Company}, Age: {user.Age}, Is married {(user.IsMarried? "yes" : "no")} ");
        }
    }
}

using Patterns.Impl.Creational.Prototype;
using System;

namespace Patterns.Contexts
{
    public class PrototypeContext : IContext
    {
        public void Excecute()
        {
            Person jack = new Person
            {
                Age = 42,
                BirthDate = Convert.ToDateTime("1977-01-01"),
                Name = "Jack Daniels",
                IdInfo = new IdInfo(666)
            };

            Person robert = jack.ShallowCopy();

            Person tom = jack.DeepCopy();

            Console.WriteLine("Jack:");
            DisplayValues(jack);
            Console.WriteLine();

            Console.WriteLine("Robert:");
            DisplayValues(robert);
            Console.WriteLine();

            Console.WriteLine("Tom:");
            DisplayValues(tom);
            Console.WriteLine();

            jack.Age = 32;
            jack.BirthDate = Convert.ToDateTime("1900-01-01");
            jack.Name = "Jacky";
            jack.IdInfo.IdNumber = 7878;
            Console.WriteLine("Jack, Robert и Tom после изменения Jack:");

            Console.WriteLine("Jack:");
            DisplayValues(jack);
            Console.WriteLine();

            Console.WriteLine("Robert:");
            DisplayValues(robert);
            Console.WriteLine();

            Console.WriteLine("Tom:");
            DisplayValues(tom);

            Console.WriteLine();
        }

        private static void DisplayValues(Person person)
        {
            Console.WriteLine($"Name: {person.Name:s}, Age: {person.Age:d}, BirthDate: {person.BirthDate:MM/dd/yy}");
            Console.WriteLine($"ID#: {person.IdInfo.IdNumber:d}");
        }
    }
}

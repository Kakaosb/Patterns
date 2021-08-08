using Patterns.Impl.Creational.Builder;
using System;

namespace Patterns.Contexts
{
    public class BuilderContext : IContext
    {
        public void Excecute()
        {
            var director = new Director();
            var builder = new ElliteBuilder();
            director.Builder = builder;

            Console.WriteLine("Standard basic house:");
            director.BuildMinimalViableHouse();
            Console.WriteLine(builder.GetHouse().ListParts());

            Console.WriteLine("Standard full featured house:");
            director.BuildFullFeaturedHouse();
            Console.WriteLine(builder.GetHouse().ListParts());

            // можно использовать без класса Директор.
            Console.WriteLine("Custom house:");
            builder.BuildFloor();
            builder.BuildRoof();
            Console.Write(builder.GetHouse().ListParts());

            Console.WriteLine();
        }
    }
}

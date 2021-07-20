using Patterns.Def.Structural.Composit;
using Patterns.Impl.Structural.Composit;
using System;

namespace Patterns.Contexts
{
    public class CompositeContext : IContext
    {
        public void Excecute()
        {
            Client client = new Client();

            Thing thing = new Thing("Мочалка");

            Console.WriteLine("Client: Положили какой-то предмет:");
            client.ClientCode(thing);

            Box mainBox = new Box();

            Box box1 = new Box();
            box1.Add(new Thing("Горошек"));
            box1.Add(new Thing("Подушка"));

            Box box2 = new Box();
            box2.Add(new Thing("Чай"));

            mainBox.Add(box1);
            mainBox.Add(box2);

            Console.WriteLine("Client: А теперь какая-то коробка:");
            client.ClientCode(mainBox);

            Console.Write("Client: Мне не нужно управлять всеми цепочками вложенностей. Оно там всё само\n");
            client.ClientCode2(mainBox, thing);

            Console.WriteLine();
        } 

        private class Client
        {
            public void ClientCode(Component component)
            {
                Console.WriteLine($"RESULT: {component.Operation()}\n");
            }

            public void ClientCode2(Component component1, Component component2)
            {
                if (component1.IsBox())
                {
                    component1.Add(component2);
                }

                Console.WriteLine($"RESULT: {component1.Operation()}");
            }
        }
    }
}
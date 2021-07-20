using Patterns.Impl.Structural.Bridge;
using System;

namespace Patterns.Contexts
{
    public class BridgeContext : IContext
    {
        public void Excecute()
        {
            Client client = new Client();

            UserInterface userInterface;

            // Клиентский код должен работать с любой предварительно
            // сконфигурированной комбинацией абстракции и реализации.
            userInterface = new UserInterface(new Pigeon());
            client.ClientCode(userInterface);

            Console.WriteLine();

            userInterface = new ExtendedUI(new Internet());
            client.ClientCode(userInterface);

            Console.WriteLine();
        }

        class Client
        {
            public void ClientCode(UserInterface userInterface)
            {
                Console.Write(userInterface.SendQuery());
            }
        }
    }
}

using Patterns.Def.Behavior.TemplateMethod;
using Patterns.Impl.Behavior.TemplateMthod;
using System;

namespace Patterns.Contexts
{
    public class TemplateMethodContext : IContext
    {
        public void Excecute()
        {
            Console.WriteLine("Прекрасная милая девушка:");
            Console.WriteLine();
            Client.ClientCode(new SoftWoman());

            Console.WriteLine();

            Console.WriteLine("Потрясающая энергичная девушка:");
            Console.WriteLine();
            Client.ClientCode(new HardWoman());

            Console.WriteLine();
        }

        class Client
        {
            public static void ClientCode(JustWomanAbstract abstractClass)
            {
                abstractClass.TemplateMethod();
            }
        }
    }
}
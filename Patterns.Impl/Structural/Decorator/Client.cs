using Patterns.Def.Structural.Decorator;

namespace Patterns.Impl.Structural.Decorator
{
    public class Client 
    {
        public void SendReportToDeveloper(Notifier notifier)
        {
            Message message = new Message()
            {
                Body = @"""Мало свободного места на диске C:"""
            };

            notifier.Send(message);
        }
    }
}

using System;
using Patterns.Def.Structural.Decorator;

namespace Patterns.Impl.Structural.Decorator
{
    public class EmailMessage : Message
    {
        public string Address
        {
            get
            {
                return "developer@email.ty";
            }
        }

        public EmailMessage(Message message)
        {
            this.Body = message.Body;
        }
    }
}

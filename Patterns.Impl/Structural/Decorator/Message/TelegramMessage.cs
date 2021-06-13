using Patterns.Def.Structural.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Impl.Structural.Decorator
{
    public class TelegramMessage : Message
    {
        public string Login
        {
            get
            {
                return "@developer";
            }
        }

        public TelegramMessage(Message message)
        {
            this.Body = message.Body;
        }
    }
}

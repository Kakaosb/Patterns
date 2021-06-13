using Patterns.Def.Structural.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Impl.Structural.Decorator
{
   public class SmsMessage : Message
    {
        public string Phone
        {
            get
            {
                return "+79008887766";
            }
        }

        public SmsMessage(Message message) {
            this.Body = message.Body;
        }
    }
}

using Patterns.Def.Structural.Proxy;
using System;

namespace Patterns.Impl.Structural.Proxy
{
    public class Proxy : ISubject
    {
        private RealSubject _realSubject;

        public Proxy(RealSubject realSubject)
        {
            this._realSubject = realSubject;
        }

        public void Request()
        {
            if (this.CheckAccess())
            {
                this._realSubject.Request();

                this.LogAccess();
            }
        }

        public bool CheckAccess()
        {
            Console.WriteLine("Proxy: проверяет наличие разрешений доступа к объекту");

            return true;
        }

        public void LogAccess()
        {
            Console.WriteLine("Proxy: логирует время выполнения");
        }
    }
}

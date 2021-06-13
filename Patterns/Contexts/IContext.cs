using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Contexts
{
    public interface IContext
    {
        /// <summary>
        /// Выполнение действий по замыслу паттерна
        /// </summary>
        void Excecute();
    }
}

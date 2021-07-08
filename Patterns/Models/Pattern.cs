using Patterns.Contexts;
using System;

namespace Patterns.Models
{
    public class Pattern
    {
        /// <summary>
        /// Ключ
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Получение контекста паттерна
        /// </summary>
        public Func<IContext> GetContextAction { get; set; }

        /// <summary>
        /// Описание паттерна
        /// </summary>
        public string Discription { get; set; }
    }
}

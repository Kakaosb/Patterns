using System;

namespace Patterns.Def.Behavior.TemplateMethod
{
    public abstract class JustWomanAbstract
    {
        public void TemplateMethod()
        {
            this.BaseOperation1();
            this.MakeSalad();
            this.BaseOperation2();
            this.Hook1();
            this.DoMakeup();
            this.BaseOperation3();
            this.Hook2();
        }

        protected void BaseOperation1()
        {
            Console.WriteLine("- быть утром в хорошем настроении");
        }

        protected void BaseOperation2()
        {
            Console.WriteLine("- расстроиться из-за пустяка");
        }

        protected void BaseOperation3()
        {
            Console.WriteLine("- пожаловаться подруге");
        }

        protected abstract void MakeSalad();

        protected abstract void DoMakeup();

        protected virtual void Hook1() { }

        protected virtual void Hook2() { }
    }
}                
using Patterns.Def.Behavior.TemplateMethod;
using System;

namespace Patterns.Impl.Behavior.TemplateMthod
{
    public class SoftWoman : JustWomanAbstract
    {
        protected override void MakeSalad()
        {
            Console.WriteLine("- сделать салат: легкий салатик из фруктов");
        }

        protected override void DoMakeup()
        {
            Console.WriteLine("- сделать мейк: нежный в стиле нюд");
        }
    }

    public class HardWoman : JustWomanAbstract
    {
        protected override void Hook1()
        {
            Console.WriteLine("- полабать на электрухе");
        }

        protected override void MakeSalad()
        {
            Console.WriteLine("- сделать салат: остренько и мяса побольше");
        }

        protected override void DoMakeup()
        {
            Console.WriteLine("- сделать мейк: ярко броско в стиле женщины-вамп");
        }
    }
}
using System;

namespace Patterns.Impl.Behavior.Visitor
{
    public class VisitorPlay : IVisitor
    {
        public void VisitDrums(Drums element)
        {
            Console.WriteLine(element.ExclusiveMethodOfDrums() + " + поиграли на ударной устновке");
        }

        public void VisitPiano(Piano element)
        {
            Console.WriteLine(element.SpecialMethodOfConcreteComponentB() + " + поиграли на пианино");
        }
    }
}

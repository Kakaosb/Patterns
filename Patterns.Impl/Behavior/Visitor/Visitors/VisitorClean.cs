using System;

namespace Patterns.Impl.Behavior.Visitor
{
    public class VisitorClean : IVisitor
    {
        public void VisitDrums(Drums element)
        {
            Console.WriteLine(element.ExclusiveMethodOfDrums() + " + почистили ударную установку");
        }

        public void VisitPiano(Piano element)
        {
            Console.WriteLine(element.SpecialMethodOfConcreteComponentB() + " + почистили пианино");
        }
    }
}

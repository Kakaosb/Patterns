using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Def.Creational
{
    public interface IAbstractChair
    {
        void LookPretty();

        void StayTogether(IAbstractSofa collaborator);
    }
}

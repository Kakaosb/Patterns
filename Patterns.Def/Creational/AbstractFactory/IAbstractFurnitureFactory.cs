using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Def.Creational
{
    public interface IAbstractFurnitureFactory
    {
        IAbstractSofa CreateSofa();

        IAbstractChair CreateChair();
    }
}

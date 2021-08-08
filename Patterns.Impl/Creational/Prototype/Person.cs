using System;

namespace Patterns.Impl.Creational.Prototype
{
    public class Person
    {
        public int Age;
        public DateTime BirthDate;
        public string Name;
        public IdInfo IdInfo;

        public Person ShallowCopy()
        {
            return (Person)MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = ShallowCopy();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = string.Copy(Name);

            return clone;
        }
    }
}

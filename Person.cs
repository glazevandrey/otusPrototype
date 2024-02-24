using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otusPrototype
{
    public class Person : IMyCloneable<Person>
    {
        public string Name;
        public Person()
        {
            
        }
        public Person(Person person)
        {
            this.Name = person.Name;
        }
        public Person Clone() => new Person(this);
       

        public string getName()
        {
            return Name;
        }

    }
}

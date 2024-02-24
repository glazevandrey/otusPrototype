using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otusPrototype
{
    public class Director : Employee, ICloneable
    {
        public string TestWords = "Im Director!";
        public string getVoice()
        {
            return TestWords;
        }
        public Director()
        {
            
        }
        public Director(Director mana) : base(mana)
        {
            this.TestWords = mana.TestWords;
        }
        public object Clone() => new Director(this);


    }
}

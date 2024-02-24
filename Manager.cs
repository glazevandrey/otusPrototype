using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace otusPrototype
{
    public class Manager : Employee, IMyCloneable<Manager>
    {
        public string TestWords  = "Im Manager!";
        public string getVoice()
        {
            return TestWords;
        }
        public Manager()
        {
            
        }
        public Manager(Manager mana) : base(mana)
        {
            this.TestWords = mana.TestWords;   
        }
        public Manager Clone() => new Manager(this);

    }
}

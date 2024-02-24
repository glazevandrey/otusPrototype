using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otusPrototype
{
    public interface IMyCloneable<T> where T : IMyCloneable<T>
    {
        T Clone();
    }

}

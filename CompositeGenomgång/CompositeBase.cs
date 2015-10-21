using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeGenomgång
{
    abstract class CompositeBase
    {
        public abstract void AddItem(CompositeBase cb);
        public abstract void RemoveItem(CompositeBase cb);
        public abstract decimal Cost { get; }
    }
}

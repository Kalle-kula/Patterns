using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeGenomgång
{
    class Part : CompositeBase
    {
        string name;
        decimal cost;
        
        public Part(string name, decimal cost)
        {
            this.name = name;
            this.cost = cost;
        }

        public override decimal Cost
        {
            get
            {
                return this.cost;
            }
        }

        public override void AddItem(CompositeBase cb)
        {
            throw new NotImplementedException();
        }

        public override void RemoveItem(CompositeBase cb)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResposibilityGenomgång
{
    class AbstractCalcHandler : ICalcHandler
    {
        protected int i1;
        protected int i2;
        protected string op;

        public virtual bool MatchesOperator
        {
            get
            {
                throw new NotImplementedException();
            }            
        }

        public ICalcHandler NextHandler
        {
            get; //autoprop, behöver inte definera ett privat fält
            set;            
        }

        public virtual void Handle(int i1, int i2, string op)
        {
            this.i1 = i1;
            this.i2 = i2;
            this.op = op;
        }
    }
}

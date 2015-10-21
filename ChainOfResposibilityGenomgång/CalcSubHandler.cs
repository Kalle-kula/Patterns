using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResposibilityGenomgång
{
    class CalcSubHandler : AbstractCalcHandler
    {
        public override void Handle(int i1, int i2, string op)
        {
            base.Handle(i1, i2, op);
            if (!MatchesOperator)
                this.NextHandler.Handle(i1, i2, op);
            else
                Console.WriteLine("Sub result = {0} - {1} = {2}", i1, i2, i1 - i2);
        }
        public override bool MatchesOperator
        {
            get
            {
                return this.op == "-";
            }
        }
    }
}

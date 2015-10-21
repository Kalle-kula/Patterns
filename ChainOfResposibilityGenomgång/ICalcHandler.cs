using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResposibilityGenomgång
{
    interface ICalcHandler
    {
        ICalcHandler NextHandler { get; set; }
        void Handle(int i1, int i2, string op);
        bool MatchesOperator { get; }
    }
}

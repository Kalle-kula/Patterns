using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandGenomgång
{
    class Fjärrkontroll
    {
        IRemoteCommand upp;
        IRemoteCommand ner;
        public Fjärrkontroll(IRemoteCommand upp, IRemoteCommand ner)
        {
            this.upp = upp;
            this.ner = ner;
        }
        public void Plus()
        {
            upp.Execute();
        }
        public void Minus()
        {
            ner.Execute();
        }
    }
}

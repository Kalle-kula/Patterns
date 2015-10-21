using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandGenomgång
{
    class HissUpp :IRemoteCommand
    {
        private Hiss hiss;

        public HissUpp(Hiss hiss)
        {
            this.hiss = hiss;
        }

        public void Execute()
        {
            hiss.ÅkaUppEnVåning();
        }        
    }
}

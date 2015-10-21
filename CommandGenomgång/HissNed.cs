using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandGenomgång
{
    class HissNed : IRemoteCommand
    {
        private Hiss hiss;

        public HissNed(Hiss hiss)
        {
            this.hiss = hiss;
        }
        public void Execute()
        {
            hiss.ÅkaNerEnVåning();
        }
    }
}

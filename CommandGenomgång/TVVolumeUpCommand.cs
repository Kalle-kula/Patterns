using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandGenomgång
{
    class TVVolumeUpCommand : IRemoteCommand
    {
        private TV tv;

        public TVVolumeUpCommand(TV tv)
        {
            this.tv = tv;
        }
        public void Execute()
        {
            tv.TurnVolumeUp();
        }

    }
}

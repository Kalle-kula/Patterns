using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandGenomgång
{
    class TVVolumeDownCommand : IRemoteCommand
    {
        private TV tv;
        public TVVolumeDownCommand(TV tv)
        {
            this.tv = tv;
        }
        public void Execute()
        {
            tv.TurnVolumeDown();
        }
    }
}

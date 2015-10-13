using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class TvTurnUpp : ICommand
    {
        IElectronicDevice theDevice;

        public TvTurnUpp(IElectronicDevice newDevice)
        {
            theDevice = newDevice;
        }
        public void execute()
        {
            theDevice.volumeUp();
        }

        public void undo()
        {
            theDevice.volumeDown();
        }
    }
}

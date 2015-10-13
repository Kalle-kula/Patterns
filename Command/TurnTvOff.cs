using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class TurnTvOff : ICommand
    {
        IElectronicDevice theDevice;

        public TurnTvOff(IElectronicDevice newDevice)
        {
            theDevice = newDevice;
        }
        public void execute()
        {
            theDevice.off();
        }

        public void undo()
        {
            theDevice.on();
        }
    }
}

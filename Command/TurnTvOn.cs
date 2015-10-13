using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class TurnTvOn : ICommand
    {
        IElectronicDevice theDevice;

        public TurnTvOn(IElectronicDevice newDevice)
        {
            theDevice = newDevice;
        }
        public void execute()
        {
            theDevice.on();
        }

        public void undo()
        {
            theDevice.off();
        }
    }
}

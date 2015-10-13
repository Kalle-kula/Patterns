using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class TurnTvDown : ICommand
    {
        IElectronicDevice theDevice;

        public TurnTvDown(IElectronicDevice newDevice)
        {
            theDevice = newDevice;
        }
        public void execute()
        {
            theDevice.volumeDown();
        }

        public void undo()
        {
            theDevice.volumeUp();
        }
    }
}

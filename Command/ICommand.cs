using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public interface ICommand
    {
        // Each command you want to issue will implement 
        // the Command interface
        void execute();
        // You may want to offer the option to undo a command
        void undo();
    }
}

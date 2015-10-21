using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public interface IATMState
    {
        void insertCard();
        void ejectCard();
        void insertPin(int pinEntered);
        void requestCash(int cashToWithdraw);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    // This is the Target Interface : This is what the client
	// expects to work with. It is the adapters job to make new
	// classes compatible with this one.

    public interface IEnemyAttacker
    {
        void fireWeapon();
        void driveForward();
        void assignDriver(string driverName);
    }
}

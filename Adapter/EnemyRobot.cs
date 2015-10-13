using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    // This is the Adaptee. The Adapter sends method calls
	// to objects that use the EnemyAttacker interface
	// to the right methods defined in EnemyRobot

    class EnemyRobot
    {
        Random generator = new Random();
    }
}

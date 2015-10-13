using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    // The Adapter must provide an alternative action for
	// the the methods that need to be used because
	// EnemyAttacker was implemented.
	 
	// This adapter does this by containing an object
	// of the same type as the Adaptee (EnemyRobot)
	// All calls to EnemyAttacker methods are sent
	// instead to methods used by EnemyRobot

    class EnemyRobotAdapter : IEnemyAttacker
    {
        EnemyRobot theRobot;

        public EnemyRobotAdapter(EnemyRobot newRobot)
        {
            theRobot = newRobot;
        }

        public void fireWeapon()
        {
            theRobot.smashWithHands();
        }

        public void driveForward()
        {
            theRobot.walkForward();
        }

        public void assignDriver(string driverName)
        {
            theRobot.reactToHuman(driverName);
        }        
    }
}

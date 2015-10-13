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

        public void smashWithHands()
        {
            int attackDamage = generator.Next(10) + 1;
            Console.WriteLine("Enemy robot causes " + attackDamage + " damage with it's hands");
        }

        public void walkForward()
        {
            int movement = generator.Next(5) + 1;
            Console.WriteLine("Enemy robot moves " + movement + " spaces");
        }

        public void reactToHuman(string driverName)
        {
            Console.WriteLine("Enemy robot crushes " + driverName);
            Console.ReadLine();
        }
        
    }
}

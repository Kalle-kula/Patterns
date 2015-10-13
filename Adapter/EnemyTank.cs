using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    // EnemyTank implements EnemyAttacker perfectly
	// Our job is to make classes with different methods
	// from EnemyAttacker to work with the EnemyAttacker interface

    class EnemyTank : IEnemyAttacker
    {
        Random generator = new Random();

        public void fireWeapon()
        {
            int attackDamage = generator.Next(10) + 1;
            Console.WriteLine("Enemy tank does " + attackDamage + " damage");
        }

        public void driveForward()
        {
            int movement = generator.Next(5) + 1;
            Console.WriteLine("Enemy Tank moves " + movement + " spaces");
        }

        public void assignDriver(string driverName)
        {
            Console.WriteLine(driverName + " is driving the tank");
            Console.ReadLine();
        }

            
    }
}

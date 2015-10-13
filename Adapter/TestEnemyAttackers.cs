using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class TestEnemyAttackers
    {
        static void Main(string[] args)
        {
            EnemyTank rx7Tank = new EnemyTank();

            EnemyRobot KalleTheRobot = new EnemyRobot();

            EnemyAttacker robotAdapter = new EnemyRobotAdapter(KalleTheRobot);

            Console.WriteLine("The Robot (EnemyRobot.cs)");

            KalleTheRobot.reactToHuman("Paul");
            KalleTheRobot.walkForward();
            KalleTheRobot.smashWithHands();
            Console.WriteLine();

            Console.WriteLine("The enemy tank (EnenmyTank.cs)");
            rx7Tank.assignDriver("Frank");
            rx7Tank.driveForward();
            rx7Tank.fireWeapon();
            Console.WriteLine();

            Console.WriteLine("The robot with adapter (EnemyRobotAdapter.cs)");
            robotAdapter.assignDriver("Mark");
            robotAdapter.driveForward();
            robotAdapter.fireWeapon();


            Console.ReadLine();

        }
    }
}

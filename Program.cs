using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            BattleField battleField = new BattleField();

            Robot robot1 = new Robot("Robot SR.", 100, 100, 10);
            Robot robot2 = new Robot("Robot Jr.", 100, 100, 10);
            Robot robot3 = new Robot("Robot The III", 100, 100, 10);

            Dinosaur dino1 = new Dinosaur("T-Rex", 100, 100, 10);
            Dinosaur dino2 = new Dinosaur("Stegasaurous", 100, 100, 10);
            Dinosaur dino3 = new Dinosaur("Velociraptor", 100, 100, 10);

            battleField.fleet.AddRobotToFleet(robot1);
            battleField.herd.AddDinoToHerd(dino1);

            Console.ReadLine();
        }
    }
}

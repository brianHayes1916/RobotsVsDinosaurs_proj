using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet
    {
        public List<Robot> robots;


        // Constructor
        
        public Fleet()
        {
            robots = new List<Robot>();
            Robot robot1 = new Robot("Robot SR.", 100, 100, 10, 0);
            Robot robot2 = new Robot("Robot Jr.", 100, 100, 10, 1);
            Robot robot3 = new Robot("Robot The III", 100, 100, 10, 2);
            AddRobotToFleet(robot1);
            AddRobotToFleet(robot2);
            AddRobotToFleet(robot3);
        }

        public void AddRobotToFleet(Robot robot)
        {
            robots.Add(robot);
        }







    }



}

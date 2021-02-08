using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet
    {
        List<Robot> robots;


        // Constructor
        
        public Fleet()
        {
            List<Robot> robots = new List<Robot>();
        }

        public void AddRobotToFleet(Robot robot)
        {
            robots.Add(robot);
        }







    }



}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class BattleField
    {
        public Herd herd;
        public Fleet fleet;

        //Constructor

        public BattleField()
        {
            herd = new Herd();
            fleet = new Fleet();
        }

     public void Battle()
        {
            while(herd.dinosaurs.Count > 0 && fleet.robots.Count > 0)
            {
                Dinosaur fightingDino = herd.dinosaurs[0];
                Robot fightingRobo = fleet.robots[0];
                fightingDino.DinoAttack(fightingRobo);
                if(fightingRobo.health <= 0)
                {
                    fleet.robots.RemoveAt(0);
                    continue;
                }
                fightingRobo.RoboAttack(fightingDino);
                if (fightingRobo.health > 0)
                {
                    herd.dinosaurs.RemoveAt(0);
                    continue;
                }
            }
            if(herd.dinosaurs.Count > 0)
            {
                Console.WriteLine("The Dinos win!");
            }
            else
            {
                Console.WriteLine("The Robots Win!");
            }

        }


    }
}

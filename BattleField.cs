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

        public void WhoFirst()
        {
            bool input = false;
            while (input == false)
            {
                Console.WriteLine("Would you like the dinosaurs or the robots to go first? Enter as shown.");
                string first = Console.ReadLine();
                if (first == "dinosaurs")
                {
                    input = true;
                    BattleDinoFirst();
                }
                else if (first == "robots")
                {
                    input = true;
                    BattleRoboFirst();
                }
                else
                {
                    Console.WriteLine("That's not a valid input please try again.");
                }
            }
        }

     public void BattleDinoFirst()
        {
            while(herd.dinosaurs.Count > 0 && fleet.robots.Count > 0)
            {
                Dinosaur fightingDino = herd.dinosaurs[0];
                Robot fightingRobo = fleet.robots[0];
                fightingDino.AttackAtempt(fightingRobo);
                if(fightingRobo.health <= 0)
                {
                    Console.WriteLine($"The robot know as {fightingRobo.name} has died!");
                    fleet.robots.RemoveAt(0);
                    continue;
                }
                fightingRobo.AttackAtempt(fightingDino);
                if (fightingDino.health <= 0)
                {
                    Console.WriteLine($"The dinosaur know as {fightingDino.dinoType} has died!");
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
        public void BattleRoboFirst()
        {
            while (herd.dinosaurs.Count > 0 && fleet.robots.Count > 0)
            {
                Dinosaur fightingDino = herd.dinosaurs[0];
                Robot fightingRobo = fleet.robots[0];
                fightingRobo.AttackAtempt(fightingDino);
                if (fightingDino.health <= 0)
                {
                    Console.WriteLine($"The dinosaur know as {fightingDino.dinoType} has died!");
                    herd.dinosaurs.RemoveAt(0);
                    continue;
                }
                fightingDino.AttackAtempt(fightingRobo);
                if (fightingRobo.health <= 0)
                {
                    Console.WriteLine($"The robot know as {fightingRobo.name} has died!");
                    fleet.robots.RemoveAt(0);
                    continue;
                }
            }
            if (herd.dinosaurs.Count > 0)
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

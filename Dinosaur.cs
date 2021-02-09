using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur
    {
        public string dinoType;
        public double health;
        public double energy;
        public double attackPower;
        public Random attackChance;

        // constructor

        public Dinosaur(string dinoType, double health, double energy, double attackPower)
        {
            this.dinoType = dinoType;
            this.health = health;
            this.energy = energy;
            this.attackPower = attackPower;
            attackChance = new Random();
        }

        public void AttackAtempt(Robot robot)
        {
            int atempt = attackChance.Next(1, 3);
            if(atempt == 2)
            {
                Console.WriteLine("The Dino's attack hits!");
                DinoAttack(robot);
            }
            else
            {
                Console.WriteLine("The Dino's attack missed!");
            }
        }

        //why was this so easy it's two steps should i make multiple variables
        public void DinoAttack(Robot robot)
        {
            robot.health -= attackPower;
        }

    }
}

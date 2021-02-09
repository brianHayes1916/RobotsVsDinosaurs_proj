using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot
    {
        public string name;
        public double health;
        public double powerLevel;
        public Weapon weapon;
        public Random attackChance;

        // constructor

        public Robot(string name, double health, double powerLevel, double attackPower)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            weapon = new Weapon();
            attackChance = new Random();
        }

        public void AttackAtempt(Dinosaur dino)
        {
            int atempt = attackChance.Next(1, 3);
            if(atempt == 2)
            {
                Console.WriteLine("The Robots attack hits!");
                RoboAttack(dino);
            }
            else
            {
                Console.WriteLine("The Robot's attack missed!");
            }
        }

        public void RoboAttack(Dinosaur dino)
        {
            dino.health -= weapon.attackPower;
        }

    }
}

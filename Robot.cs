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

        // constructor

        public Robot(string name, double health, double powerLevel, double attackPower)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            weapon = new Weapon();
        }

        //is it ok to change the origonal value of things like health
        //should this to go in the battlefield
        public void RoboAttack(Dinosaur dino)
        {
            dino.health -= weapon.attackPower;
        }

    }
}

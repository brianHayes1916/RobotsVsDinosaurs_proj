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
        public double attackPower;

        // constructor

        public Robot(string name, double health, double powerLevel, double attackPower)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            this.attackPower = attackPower;
            weapon = new Weapon();
        }



    }
}

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

        // constructor

        public Dinosaur(string dinoType, double health, double energy, double attackPower)
        {
            this.dinoType = dinoType;
            this.health = health;
            this.energy = energy;
            this.attackPower = attackPower;
        }

        //why was this so easy it's two steps should i make multiple variables
        public void DinoAttack(Robot robot)
        {
            robot.health -= attackPower;
        }

    }
}

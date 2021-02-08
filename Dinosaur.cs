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


    }
}

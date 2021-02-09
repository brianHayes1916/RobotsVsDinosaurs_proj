using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Weapon
    {
        public double attackPower;
        public string name;

        public Weapon(double attackPower, string name)
        {
            this.attackPower = attackPower;
            this.name = name;
        }
    }
}

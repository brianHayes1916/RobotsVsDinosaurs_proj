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
        public List<Weapon> weapons;

        // constructor

        public Robot(string name, double health, double powerLevel, double attackPower, int weaponPick)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            attackChance = new Random();
            weapons = new List<Weapon>();
            Weapon fish = new Weapon(10, "Wet Fish");
            Weapon curtain = new Weapon(5, "Curtain Rod");
            Weapon spork = new Weapon(20, "Spork");
            weapons.Add(fish);
            weapons.Add(spork);
            weapons.Add(curtain);
            weapon = new Weapon(0,null);
            weapon = weapons[weaponPick];
        }

        public void AttackAtempt(Dinosaur dino)
        {
            powerLevel -= 10;
            int atempt = attackChance.Next(1, 3);
            if(atempt == 2)
            {
                Console.WriteLine($"The Robots attack hits with a {weapon.name}!");
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

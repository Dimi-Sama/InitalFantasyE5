using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeux_E5
{
    public class Combatant
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Healing { get; set; }
        public int MaxHealth { get; set; }


        protected Random random = new Random();

       protected Combatant(string name, int health, int damage, int healing)
        {
            Name = name;
            MaxHealth = health;
            Health = health;
            Damage = damage;
            Healing = healing;
        }
        public (bool, int) Attack(Combatant target)
        {
            int missChance = 5;
            int critChance = 20;
            int minDamage = (int)(Damage * 0.8);
            int maxDamage = (int)(Damage * 1.2);

            bool hit = random.Next(0, 100) >= missChance;
            int damage = 0;

            if (hit)
            {
                damage = random.Next(minDamage, maxDamage + 1);

                if (random.Next(0, 100) < critChance)
                {
                    damage *= 2;
                }

                target.Health -= damage;
                if (target.Health < 0)
                {
                    target.Health = 0;
                }
            }

            return (hit, damage);
        }

        public void Heal()
        {

            Health += Healing;
            if (Health > MaxHealth)
            {
                Health = MaxHealth;
            }
            Console.WriteLine($"{Name} récupère {Healing} points de vie. Points de vie restants : {Health}");
        }

    }
}

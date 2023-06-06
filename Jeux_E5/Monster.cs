using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeux_E5
{
    public class Monster : Combatant
    {
        public bool IsEnraged { get; set; }

        public Monster(string name, int health, int damage, int healing)
            : base(name, health, damage, healing)
        {
        }
        public void ResetStats()
        {
            Health = MaxHealth;
            IsEnraged = false; 
        }

        public void Enrage()
        {
            if (!IsEnraged && Health < (MaxHealth * 0.3))
            {
                IsEnraged = true;
                Damage = (int)(Damage * 1.5);
                Console.WriteLine($"{Name} est enragé !");
            }
        }


    }
}

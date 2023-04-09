using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeux_E5
{
    public class Player : Combatant
    {
        public int Mana { get; set; }
        public int MaxMana { get; set; }

        public Player(string name, int health, int damage, int healing, int maxMana)
    : base(name, health, damage, healing)
        {
            MaxMana = maxMana;
            Mana = maxMana;
        }
        public void ResetStats()
        {
            Health = MaxHealth;
            Mana = MaxMana;
        }


        public int DoubleAttack(Combatant target, int manaCost)
        {
            if (Mana >= manaCost)
            {
                Mana -= manaCost;

                // Effectue les deux attaques et stocke les résultats dans des variables séparées
                (bool hit1, int damage1) = Attack(target);
                (bool hit2, int damage2) = Attack(target);

                // Calcule le total des dégâts
                int totalDamage = damage1 + damage2;

                return totalDamage;
            }
            else
            {
                Console.WriteLine("Pas assez de Mana !");
                return 0;
            }
        }

    }
}

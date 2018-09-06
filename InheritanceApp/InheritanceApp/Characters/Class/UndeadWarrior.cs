using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Characters.Class
{
    /// <summary>
    /// This type of Warrior has a chance to poison the enemy.
    /// </summary>
    class UndeadWarrior : Warrior
    {
        /// <summary>
        /// True if the enemy is poisoned.
        /// </summary>
        bool poison;

        /// <summary>
        /// Public constructor, sets undead to true.
        /// </summary>
        /// <param name="full_name">This Warrior's given name.</param>
        public UndeadWarrior(string full_name) : base(full_name, true)
        {
            poison = false;
        }

        /// <summary>
        /// Deals damage to an enemy with a sword attack. Has a 30% chance for poisoning the enemy.
        /// </summary>
        /// <param name="enemy">Enemy to hit.</param>
        /// <returns>Damage dealt (between 1 and 3).</returns>
        public override int Attack(ICharacter enemy)
        {
            int damage = rng.Next(1, 4);
            Console.WriteLine(name + " deals " + damage + " damage to " + enemy.GetName() + ".");
            enemy.TakeDamage(damage);
            
            if (!poison && rng.Next(1, 11) > 7)
            {
                Console.WriteLine(enemy.GetName() + " is now poisoned.");
                poison = true;
            }
            else if (poison)
            {
                Console.WriteLine(enemy.GetName() + " takes 2 damage from poison.");
                enemy.TakeDamage(2);
            }

            return damage;
        }
    }
}

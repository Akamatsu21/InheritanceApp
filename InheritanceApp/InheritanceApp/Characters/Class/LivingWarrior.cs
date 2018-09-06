using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Characters.Class
{
    /// <summary>
    /// This type of Warrior gets stronger when low on health.
    /// </summary>
    class LivingWarrior : Warrior
    {
        /// <summary>
        /// Public constructor, sets undead to false.
        /// </summary>
        /// <param name="full_name">This Warrior's given name.</param>
        public LivingWarrior(string full_name) : base(full_name, false)
        {}

        /// <summary>
        /// Deals damage to an enemy with a sword attack. Has a 30% chance for a critical hit when low on health.
        /// </summary>
        /// <param name="enemy">Enemy to hit.</param>
        /// <returns>Damage dealt (between 1 and 3).</returns>
        public override int Attack(ICharacter enemy)
        {
            int damage = rng.Next(1, 4);
            if (hp < 5 && rng.Next(1, 11) > 7)
            {
                damage = 10;
                Console.WriteLine(name + " entered berserk!");
            }
            Console.WriteLine(name + " deals " + damage + " damage to " + enemy.GetName() + ".");
            enemy.TakeDamage(damage);
            return damage;
        }
    }
}

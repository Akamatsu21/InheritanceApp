using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Characters.Class
{
    /// <summary>
    /// The most beefy character, which gets stronger when low on health.
    /// </summary>
    class Warrior : ICharacter
    {
        /// <summary>
        /// Health Points of the Warrior.
        /// </summary>
        int hp;

        /// <summary>
        /// Utility Random Number Generator.
        /// </summary>
        Random rng;

        /// <summary>
        /// Warrior's name.
        /// </summary>
        string name;

        /// <summary>
        /// Boolean value which determines if this is a living Warrior or an undead Warrior.
        /// </summary>
        bool undead;

        /// <summary>
        /// Public constructor that initialises attributes.
        /// </summary>
        /// <param name="full_name">This Warrior's given name.</param>
        /// <param name="dead">True if the Warriro's undead.</param>
        public Warrior(string full_name, bool dead = false)
        {
            hp = 9;
            rng = new Random();
            name = full_name;
            undead = dead;
        }

        /// <summary>
        /// Deals damage to an enemy with a sword attack. Has a 30% chance for a critical hit when low on health.
        /// </summary>
        /// <param name="enemy">Enemy to hit.</param>
        /// <returns>Damage dealt (between 1 and 3).</returns>
        public int Attack(ICharacter enemy)
        {
            int damage = rng.Next(1, 4);
            if(hp < 4 && rng.Next(1, 11) > 7)
            {
                damage = 10;
            }
            Console.WriteLine(name + " deals " + damage + " damage to " + enemy.GetName() + ".");
            enemy.TakeDamage(damage);
            return damage;
        }

        /// <summary>
        /// Checks if the Warrior is undead.
        /// </summary>
        /// <returns>The value of the predetermined variable that decides wether a Warrior is undead.</returns>
        public bool isUndead()
        {
            return undead;
        }

        /// <summary>
        /// Take damage..
        /// </summary>
        /// <param name="damage">Damage to be dealt.</param>
        public void TakeDamage(int damage)
        {
            hp -= damage;
            Console.WriteLine(name + " takes " + damage + " damage!");
        }

        /// <summary>
        /// Get the Warrior's full name.
        /// </summary>
        /// <returns>Name string.</returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Return the Warrior's HP.
        /// </summary>
        /// <returns>Health Points.</returns>
        public int GetHP()
        {
            return hp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Characters.Race
{
    /// <summary>
    /// Liches are undead characters that can come back to life.
    /// </summary>
    class Lich : ICharacter
    {
        /// <summary>
        /// Health Points of the Lich.
        /// </summary>
        int hp;

        /// <summary>
        /// Utility Random Number Generator.
        /// </summary>
        Random rng;

        /// <summary>
        /// Lich's name.
        /// </summary>
        string name;

        /// <summary>
        /// Public constructor that initialises attributes.
        /// </summary>
        /// <param name="full_name">This Lich's given name.</param>
        public Lich(string full_name)
        {
            hp = 5;
            rng = new Random();
            name = full_name;
        }

        /// <summary>
        /// Deals damage to an enemy with a magical attack.
        /// </summary>
        /// <param name="enemy">Enemy to hit.</param>
        /// <returns>Damage dealt (between 1 and 5).</returns>
        public int Attack(ICharacter enemy)
        {
            int damage = rng.Next(1, 6);
            Console.WriteLine(name + " deals " + damage + " damage to " + enemy.GetName() + ".");
            enemy.TakeDamage(damage);
            return damage;
        }

        /// <summary>
        /// Checks if the Lich is undead.
        /// </summary>
        /// <returns>Always returns true, as a Lich has to be undead.</returns>
        public bool isUndead()
        {
            return true;
        }

        /// <summary>
        /// Take damage, with 50% chance to come back to life if the damage is fatal.
        /// </summary>
        /// <param name="damage">Damage to be dealt.</param>
        public void TakeDamage(int damage)
        {
            hp -= damage;
            Console.WriteLine(name + " takes " + damage + " damage!");
            if (hp <= 0 && rng.Next(1, 11) >= 6)
            {
                hp = 5;
                Console.WriteLine(name + " came back to life with his black magic!");
            }
        }

        /// <summary>
        /// Get the Lich's full name.
        /// </summary>
        /// <returns>Name string.</returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Return the Lich's HP.
        /// </summary>
        /// <returns>Health Points.</returns>
        public int GetHP()
        {
            return hp;
        }
    }
}

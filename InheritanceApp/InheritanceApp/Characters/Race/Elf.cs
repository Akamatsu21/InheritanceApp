using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Characters.Race
{
    /// <summary>
    /// Elfs are the fastest characters, so it's easy for them to dodge..
    /// </summary>
    class Elf : ICharacter
    {
        /// <summary>
        /// Health Points of the Elf.
        /// </summary>
        int hp;

        /// <summary>
        /// Utility Random Number Generator.
        /// </summary>
        Random rng;

        /// <summary>
        /// Elf's name.
        /// </summary>
        string name;

        /// <summary>
        /// Public constructor that initialises attributes.
        /// </summary>
        /// <param name="full_name">This Elf's given name.</param>
        public Elf(string full_name)
        {
            hp = 7;
            rng = new Random();
            name = full_name;
        }

        /// <summary>
        /// Deals damage to an enemy with a basic bow attack.
        /// </summary>
        /// <param name="enemy">Enemy to hit.</param>
        /// <returns>Damage dealt (between 1 and 4).</returns>
        public int Attack(ICharacter enemy)
        {
            int damage = rng.Next(1, 5);
            Console.WriteLine(name + " deals " + damage + " damage to " + enemy.GetName() + ".");
            enemy.TakeDamage(damage);
            return damage;
        }

        /// <summary>
        /// Checks if the Elf is undead.
        /// </summary>
        /// <returns>Always returns false, as Elves are not undead by default.</returns>
        public bool isUndead()
        {
            return false;
        }

        /// <summary>
        /// Takes damage, with 30% chance to dodge it completely.
        /// </summary>
        /// <param name="damage">Damage to be dealt.</param>
        public void TakeDamage(int damage)
        {
            if(rng.Next(1, 11) > 3)
            {
                hp -= damage;
            }
            else
            {
                Console.WriteLine(name + " dodged the attack!");
            }
        }

        /// <summary>
        /// Return the Elf's given name.
        /// </summary>
        /// <returns>Name string.</returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Return the Elf's HP.
        /// </summary>
        /// <returns>Health Points.</returns>
        public int GetHP()
        {
            return hp;
        }
    }
}

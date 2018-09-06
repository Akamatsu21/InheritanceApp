using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Characters.Class
{
    /// <summary>
    /// The character class that can heal itself and also deals double damage to undead.
    /// </summary>
    class Priest : ICharacter
    {
        /// <summary>
        /// Health Points of the Priest.
        /// </summary>
        int hp;

        /// <summary>
        /// Utility Random Number Generator.
        /// </summary>
        Random rng;

        /// <summary>
        /// Priest's name.
        /// </summary>
        string name;

        /// <summary>
        /// Public constructor that initialises attributes.
        /// </summary>
        /// <param name="full_name">This Priest's given name.</param>
        public Priest(string full_name)
        {
            hp = 7;
            rng = new Random();
            name = full_name;
        }

        /// <summary>
        /// Deals damage to an enemy with a magic attack. Has a 60% chance to heal himself by 1 each turn.
        /// </summary>
        /// <param name="enemy">Enemy to hit.</param>
        /// <returns>Damage dealt (between 1 and 4, doubled if attacking an undead).</returns>
        public int Attack(ICharacter enemy)
        {
            int damage = rng.Next(1, 5);
            if(enemy.isUndead())
            {
                damage *= 2;
            }
            if (hp < 7 && rng.Next(1, 11) > 4)
            {
                hp += 1;
                Console.WriteLine(name + " healed 1 HP.");
            }
            Console.WriteLine(name + " deals " + damage + " damage to " + enemy.GetName() + ".");
            enemy.TakeDamage(damage);
            return damage;
        }

        /// <summary>
        /// Checks if the Priest is undead.
        /// </summary>
        /// <returns>Always returns false as Priests can't be undead.</returns>
        public bool isUndead()
        {
            return false;
        }

        /// <summary>
        /// Take damage..
        /// </summary>
        /// <param name="damage">Damage to be dealt.</param>
        public void TakeDamage(int damage)
        {
            hp -= damage;
        }

        /// <summary>
        /// Get the Priest's full name.
        /// </summary>
        /// <returns>Name string.</returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Return the Priest's HP.
        /// </summary>
        /// <returns>Health Points.</returns>
        public int GetHP()
        {
            return hp;
        }
    }
}

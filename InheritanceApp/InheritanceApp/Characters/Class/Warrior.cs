using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Characters.Class
{
    /// <summary>
    /// The most beefy character, has different abilities depending on wether it's undead or not.
    /// </summary>
    abstract class Warrior : ICharacter
    {
        /// <summary>
        /// Health Points of the Warrior.
        /// </summary>
        protected int hp;

        /// <summary>
        /// Utility Random Number Generator.
        /// </summary>
        protected Random rng;

        /// <summary>
        /// Warrior's name.
        /// </summary>
        protected string name;

        /// <summary>
        /// Boolean value which determines if this is a living Warrior or an undead Warrior.
        /// </summary>
        bool undead;

        /// <summary>
        /// Public constructor that initialises attributes.
        /// </summary>
        /// <param name="full_name">This Warrior's given name.</param>
        /// <param name="dead">True if the Warrior's undead.</param>
        public Warrior(string full_name, bool dead = false)
        {
            hp = 10;
            rng = new Random();
            name = full_name;
            undead = dead;
        }

        /// <summary>
        /// Abstract function that contains the Warrior's sword attack. Implementation varies between types of Warriors.
        /// </summary>
        /// <param name="enemy">Enemy to hit.</param>
        /// <returns>Damage dealt (between 1 and 3).</returns>
        abstract public int Attack(ICharacter enemy);

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Characters
{
    interface ICharacter
    {
        /// <summary>
        /// Obtain this character's HP.
        /// </summary>
        /// <returns>Character's Health Points.</returns>
        int GetHP();

        /// <summary>
        /// Obtain this character's name.
        /// </summary>
        /// <returns>Character's full name.</returns>
        string GetName();

        /// <summary>
        /// Perform an attack on an enemy character.
        /// </summary>
        /// <param name="enemy">Character to attack.</param>
        /// <returns>Damage dealt.</returns>
        int Attack(ICharacter enemy);

        /// <summary>
        /// Deplete HP.
        /// </summary>
        /// <param name="damage">Amount of HP to lose.</param>
        void TakeDamage(int damage);

        /// <summary>
        /// Checks if the character is undead.
        /// </summary>
        /// <returns>Returns true if the character is undead.</returns>
        bool isUndead();
    }
}

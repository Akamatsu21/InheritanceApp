using InheritanceApp.Characters;
using InheritanceApp.Characters.Class;
using InheritanceApp.Characters.Race;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace InheritanceApp
{
    /// <summary>
    /// Main Program class.
    /// </summary>
    class InheritanceApp
    {
        /// <summary>
        /// Create a character based on user input.
        /// </summary>
        /// <returns>The character object.</returns>
        static ICharacter CreateCharacter()
        {
            string number = Console.ReadLine();
            Console.Write("Give this fighter a name: ");
            string name = Console.ReadLine();
            bool undead = false;
            if (number == "4")
            {
                Console.Write("Do you want the Warrior to be undead? ");
                string u = Console.ReadLine();
                if (u == "y" || u == "yes")
                {
                    undead = true;
                }
            }

            ICharacter character = null;
            switch(number)
            {
                case "1":
                    character = new Elf(name);
                    break;
                case "2":
                    character = new Lich(name);
                    break;
                case "3":
                    character = new Priest(name);
                    break;
                case "4":
                    character = new Warrior(name, undead);
                    break;
                default:
                    Console.WriteLine("Wrong value!");
                    Environment.Exit(1);
                    break;
            }

            return character;
        }
        
        /// <summary>
        /// Program starting point.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("The available fighters are:");
            Console.WriteLine("1 - Elf");
            Console.WriteLine("2 - Lich");
            Console.WriteLine("3 - Priest");
            Console.WriteLine("4 - Warrior");

            Console.Write("Pick fighter 1: ");
            ICharacter fighter1 = CreateCharacter();
            Console.Write("Pick fighter 2: ");
            ICharacter fighter2 = CreateCharacter();

            bool game_over = false;
            bool turn = true;
            while(!game_over)
            {
                if(turn)
                {
                    fighter1.Attack(fighter2);
                }
                else
                {
                    fighter2.Attack(fighter1);
                }

                turn = !turn;
                Console.WriteLine(fighter1.GetName() + ": " + fighter1.GetHP() + " HP");
                Console.WriteLine(fighter2.GetName() + ": " + fighter2.GetHP() + " HP");

                if(fighter1.GetHP() <= 0 || fighter2.GetHP() <= 0)
                {
                    string winner = (fighter1.GetHP() > fighter2.GetHP() ? fighter1.GetName() : fighter2.GetName());
                    Console.WriteLine(winner + " is victorious!");
                    game_over = true;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Thread.Sleep(3000);
                }
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon_Game
{
    class Dungeon
    {
        public List<DungeonRoom> Rooms { get; set; }

        private int DiceRoll()
        {
            Random rand = new Random();
            int diceRoll = rand.Next(1, 20);
            return diceRoll;
        }


        private void Attack(Character character, Character monster)
        {
            int roll = DiceRoll();
            if (roll <= character.CalculateHitChance() - monster.Block)
            {
                int damage = character.CalculateDamage();
                monster.Health -= damage;
                Console.WriteLine($"{monster.Name} takes {damage} damage");
            }
            else
            {
                Console.WriteLine($"{character.Name} missed!");
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Welcome to Hell";
            Weapon mace = new Weapon("Face Smasher", 5, 30, false, 1);
            Character larz = new Character("larz", 3, 100, 5, mace);
            bool exit = false;

            do
            {
                do
                {
                    Console.WriteLine("Choose your fate: \n1: Attack \n2: Run \n3: Player Info \n4: Monster Info \n5: Exit");
                    ConsoleKey userSelection = Console.ReadKey(true).Key;

                    switch (userSelection)
                    {
                        case ConsoleKey.D1:
                            {

                                break;
                            }
                        case ConsoleKey.D2:
                            {
                                break;
                            }                      
                        case ConsoleKey.D3:
                            {
                                break;
                            }
                            
                        case ConsoleKey.D4:
                            {
                                break;
                            }
                           
                        case ConsoleKey.D5:
                            {
                                exit = true;
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                }
                while (larz.Health > 0);
            } while (!exit);
        }
    }
}

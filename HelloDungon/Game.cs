using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDungeon
{
    class Game
    { 
        public void Run()
        {
            //Intro to Game
            string name = "Empty";
            Console.WriteLine("Weclome to Waistlands");
            Console.WriteLine("What is your Name");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("This is a place ware you forge your own path");
            string characterName = (name);
                                         
            //class options
            Console.WriteLine("What class would you like to choose");
            Console.WriteLine("1.Gunslinger");
            Console.WriteLine("2.Brute");

            //Intitalize default health values
            int healthRegen = 50;
            int health = 100 / 2;
            //Increase health by regen amount
            health += healthRegen;

            if (health <= 0);
            {
                            
            }
           

            //Mana 
            int mana = 100 / 2;
            int manaRegen = 50;
            mana += manaRegen;

            int currectArea = 1;
            float damage = 10;
            float speed = 10;
            float range = 10;
            bool playerIsAlive = true;
            bool gameOver = false;

            string input;

            
            //Character Classes

            string characterClass = Console.ReadLine();
            //If player selected the first option
            if (characterClass == "1" || characterClass == "Gunslinger")
            {
                //stats for Gunslinger
                characterClass = "Gunslinger";
                health = 150;
                mana = 150;
                damage = 20;
                range = 15;
                speed = 10;
            }
            //If player selected the second option
            else if (characterClass == "2" || characterClass == "Brute")
            {
                //stats for Brute
                characterClass = "Brute";
                health = 150;
                mana = 150;
                damage = 20;
                range = 10;
                speed = 15;
            }

            //If neither are true
            else
            {
                //...display error message
                Console.WriteLine("Invalid Input");
            }

            //display charcater stats
            Console.WriteLine("Your Charcater Stats\n");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Class " + characterClass);
            Console.WriteLine("Health " + health);
            Console.WriteLine("Mana " + mana);
            Console.WriteLine("Power " + damage);
            Console.WriteLine("Range " + range);
            Console.WriteLine("Speed " + speed);

            Console.ReadKey();
            Console.Clear();

            //Your first encounter
            Console.WriteLine("You've been approached by a traveler!!" + "\n They offer you a potion. Do you accept?" + "\n 1.Yes \n 2.No");

            input = Console.ReadLine();

            if (input == "1" || input == "Yes")
            {
                Console.WriteLine("You have gained a potion.");               
            }

            else if(input == "2" || input == "No")
            {
                Console.WriteLine("Traveler forces you to take it.");
            }

            Console.ReadKey();
            Console.Clear();

            
            Console.WriteLine("While traveling along you stumble across a cave!!" + "\n Do you wish to enter?" + " 1.Yes \n 2.No");

            if (input == "1" || input == "Yes")
            {
                Console.WriteLine("You eneter the cave and find a pack of wolves");
                Console.WriteLine("They attack killing you in a few seconds");
                health = 0;
            }

            else if (input == "2" || input == "No")
            {
                Console.WriteLine("You continue on your path finding a village.");
            }



        }
    }
}
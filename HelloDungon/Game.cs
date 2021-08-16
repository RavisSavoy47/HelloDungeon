using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDungeon
{
    class Game
    { 
        public void Run()
        {
            //Health exercise

            //Intitalize default health values
            int healthRegen = 50;
            int health = 100 / 2;
            //Increase health by regen amount
            health = health + healthRegen;
            health += healthRegen;
            //Display health to user
            Console.WriteLine(health);

            //Name exercise
            string name = "Empty";
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            string characterName = (name);
            int currectArea = 1;
            float damage = 10;
            float speed = 5;
            float range = 5;
           
            bool gameOver = false;
            //Mana 
            int mana = 100;
            int manaRegen = 20;
            mana += manaRegen;
            Console.WriteLine(mana);
            //introduction
            Console.WriteLine("Weclome to Waistlands");
            Console.WriteLine("This is a place ware you forge your own path");
            //class selection
            Console.WriteLine("What class would you like to choose");
            Console.Write("Choose between. Gunslinger or Brute");
            string characterClass = Console.ReadLine();
            int Gunslinger;
            int Brute;




        }
    }
}
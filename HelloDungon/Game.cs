using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDungeon
{
    class Game
    { 
       

        public void Run()
        {
            //Intitalize default health values
            int healthRegen = 50;
            int health = 100 / 2;
            //Increase health by regen amount
            health += healthRegen;
            int damage = 20;
            int range = 15;
            int speed = 10;
            string characterClass = "";
            bool gameOver = false;
            string input = "";
            string write = "";
            //Makeing sure that the player can die
            if (health == 0)
            {
                gameOver = true;
            }

            string stats;

            //Intro to Game
            string name = "Empty";
            Console.WriteLine("Weclome to Waistlands");
            Console.WriteLine("What is your Name");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("This is a place ware you forge your own path");
            string characterName = (name);

            Console.ReadKey();
            Console.Clear();

            bool vaildInput = false;
            while (vaildInput == false)
            {
                
                //class options
                Console.WriteLine("What class would you like to choose");
                Console.WriteLine("1.Gunslinger");
                Console.WriteLine("2.Brute");

                 characterClass = Console.ReadLine();
                //If player selected the first option
                if (characterClass == "1" || characterClass == "Gunslinger")
                {
                    //stats for Gunslinger
                    characterClass = "Gunslinger";
                    health = 150;
                    damage = 20;
                    range = 15;
                    speed = 10;

                    vaildInput = true;
                }
                //If player selected the second option
                else if (characterClass == "2" || characterClass == "Brute")
                {
                    //stats for Brute
                    characterClass = "Brute";
                    health = 150;
                    damage = 20;
                    range = 10;
                    speed = 15;

                    vaildInput = true;
                }
                //If neither are true
                else
                {
                    //...display error message
                    Console.WriteLine("Invalid Input");
                }
                Console.ReadKey();
                Console.Clear();
              
            }



            //display charcater stats
            Console.WriteLine("Your Charcater Stats\n");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Class " + characterClass);
            Console.WriteLine("Health " + health);
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

            else if (input == "2" || input == "No")
            {
                Console.WriteLine("Traveler forces you to take it.");
            }

            else
            {
                //...display error message
                Console.WriteLine("Invalid Input");
            }

            Console.ReadKey();
            Console.Clear();

            //First Stranger to challenge Player
            int numberOfAttempts = 1;

            Console.WriteLine("You are tackled to the ground by a crazed man!" + "\n The man gives you the option to best him in a speed match based on how he looks his speed is around 15 speed");
            Console.ReadKey();

            for (int i = 0; i < numberOfAttempts; i++)
            {
                Console.Clear();
                Console.WriteLine("Would you be able to best him?");
                int attemptsRemaining = numberOfAttempts - i;
                Console.WriteLine("Attempts Remaining: " + attemptsRemaining);
                Console.Write(">");
                input = Console.ReadLine();

                if (input == "no")
                {
                    Console.WriteLine("Good choice partner!");
                    break;
                }

                Console.WriteLine("Your perception is off a little their boy my speed is 50." + "\n You were no match for him!");
                health -= 30;
            }

            Console.ReadLine();
            Console.Clear();


            //the village
            Console.WriteLine("Welcome to the village of Bertane Im the town's Marshal you can call me by Will." + "\n If you keep walking you'll find the town saloon.");
            Console.WriteLine("We have a Quest Giver at the Saloon");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Walking down the road you approuch the towns saloon." + "\n You find out that the bar keep is the towns Quest Giver.");
            Console.WriteLine("You ask the bar keep if there are any quest that I can take?" + "\n Hi sir my name is Dave would you like to accept a quest?");
            Console.WriteLine("Now that you have accepted this quest I would like you to talk to the shop keep at the end of the town she will tell you the rest.");
            Console.WriteLine("You take the quest and walk down to the Fence to get directions.");

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("You approach the fence where the shop keep greets you." + "\n Weclome to the fence we have all you needs you may call me Shela.");
            Console.WriteLine("Lots of people been telling me that your a travler but for my view you don't look the part." + "\n She gives you an upgraded weapon!");
            damage += 30;
            Console.WriteLine("With that you should have no problem with your quest.");

            Console.Clear();

            Console.WriteLine("Your Charcater Stats\n");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Class " + characterClass);
            Console.WriteLine("Health " + health);
            Console.WriteLine("Power " + damage);
            Console.WriteLine("Range " + range);
            Console.WriteLine("Speed " + speed);

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("The quest is to kill a pack of wolves that have been recently been causing trouble with our cattle.");
            Console.WriteLine("To get to their den you walk east an cross over a river and their should be a cave near their.");
            Console.WriteLine("You start your trip but Shela grabs you and gives you better clothes." + "\n Sorry I forgot to give you this now you're set.");
            health += 50;

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("You thank her and walk east allong the way you find rusty bullets." + "\n Knowing that this might be a big fight you take your time getting their.");
            Console.WriteLine("You walk along the wood bridge and you cant seem to find the cave!" + "\n Pushing over a large rock that was standing out their appears to be a cave underneath!");


           
            











        }
    }
}
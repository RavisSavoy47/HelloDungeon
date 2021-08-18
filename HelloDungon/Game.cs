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
            bool vaildInputReceived = false;


            while (vaildInputReceived == false)
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

                    vaildInputReceived = true;
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

                    vaildInputReceived = true;
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

            Console.WriteLine("Your Charcater Stats\n");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Class " + characterClass);
            Console.WriteLine("Health " + health);
            Console.WriteLine("Power " + damage);
            Console.WriteLine("Range " + range);
            Console.WriteLine("Speed " + speed);

            Console.ReadKey();

            int currectArea = 1;

            bool playerIsAlive = true;
            

            

            //display charcater stats


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

            else
            {
                //...display error message
                Console.WriteLine("Invalid Input");
            }

            Console.ReadKey();
            Console.Clear();

            
            
                //Cave experience
                Console.WriteLine("While traveling along you stumble across a cave!!" + "\n Do you wish to enter?" + " 1.Yes \n 2.No");

                input = Console.ReadLine();
                if (input == "1" || input == "Yes")
                {
                    Console.WriteLine("You eneter the cave and find a pack of wolves");
                    Console.WriteLine("They attack killing you in a few seconds");

                    vaildInputReceived = false;
                }

                else if (input == "2" || input == "No")
                {
                    Console.WriteLine("You continue on your path finding a village.");

                    vaildInputReceived = true;
                }

                else
                {
                    //...display error message
                    Console.WriteLine("Invalid Input");

                    vaildInputReceived = false;
                }

            

           

            //Village area start
            Console.WriteLine("You are approached by an old man." + "Welcome to Barenville");
            Console.WriteLine("I am the towns marshal you can call me by Walt" + "Their aint much in this town but we have all your needs");

            int numberOfAttempts = 4;

            Console.WriteLine("A very old man with a monkey on his back approaches you." + "\n The monkey offers you imortality if you can solve a riddle in" + numberOfAttempts + " attempts");

            Console.ReadKey();

            for (int i = 0; i < numberOfAttempts; i++)
            {
                Console.Clear();
                Console.WriteLine("What month of the year has 28 days?");
                int attemptsRemaining = numberOfAttempts - i;
                Console.WriteLine("Atempts Remaining: " + attemptsRemaining);
                Console.Write(">");
                input = Console.ReadLine();

                if (input == "all of them")
                {
                    Console.WriteLine("Congrats! You've gained imortality!");
                    break;
                }

                Console.WriteLine("Incorrect! The mokey laughs at you! It hurts..." + "\n you take 5 points of damage,");
                health -= 5; 
            }

            Console.WriteLine("You are pulled into an alley way!" + "\n The person gives you the option to best him in a speed match based on how he looks is speed is around 15." 
                + "attempts");
            Console.ReadKey();

            
            for (int i = 0; i < numberOfAttempts; i++)
            {
                Console.Clear();
                Console.WriteLine("Would you be able to best me?");
                int attemptsRemaining = numberOfAttempts - i;
                Console.WriteLine("Attempts Remaining: " + attemptsRemaining);
                Console.Write(">");
                input = Console.ReadLine();

                if (input == "No")
                {
                    Console.WriteLine("Good choice partner!");
                    break;
                }

                Console.WriteLine("Your perception is off a little their boy my speed is 50" + "\n you were no match for him");
                health -= 9;
            }


        }
    }
}
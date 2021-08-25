using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDungeon
{
    class Game
    {
      
        string charcaterClass = "";
        string input = "";
        bool gameOver = false;
        string name = "Empty";
        bool inputReceived = false;

        //Intitalize default health values
        int healthRegen = 20;
        int health = 100 / 2;
        //Increase health by regen amount
       
            int damage = 20;
        int range = 15;
        int speed = 10;
        string characterClass = "";

        string write = "";
        int currentArea = 1;
        bool playerIsAlive = false;


        public void Run()
        {
            health += healthRegen;
            //Makeing sure that the player can die
            if (health <= 0)
            {

                Console.WriteLine("HaHa! You died fool!");
                return;

            }

            int GetInput(string description, string option1, string option2)
            {
                string input = ""; 
                int inputReceived = 0;

                while (!(inputReceived == 1 || inputReceived == 2))
                {
                    Console.WriteLine(description);
                    Console.WriteLine("1. " + option1);
                    Console.WriteLine("2. " + option2);
                    Console.Write("> ");

                    input = Console.ReadLine();

                    if (input == "1" || input == option1)
                    {
                        inputReceived = 1;
                    }

                    if (input == "2" || input == option2)
                    {
                        inputReceived = 2;

                    }

                    else
                    {
                        Console.WriteLine("Invalid Input");
                        Console.ReadKey();
                    }

                    Console.Clear();

                }
                return inputReceived;
            }

            void DisplayMainMenu()
            {
                int input = GetInput("Do you want to play again?", "yes", "no");

                if (input == 1)
                {
                    currentArea = 1;
                    gameOver = false;
                }

                if (input == 2)
                {
                    
                    gameOver = true;
                }


            }

            void DisplayCurrentArea()
            {
                if(currentArea == 1)
                {
                    intro();
                }

                if (currentArea == 2)
                {
                    Encounters1And2();
                }

                if (currentArea == 3)
                {
                    Village();
                }

                if (currentArea == 4)
                {
                    quest();

                }

                if (currentArea == 5)
                {
                    questBoss();
                } 
            }

            //loop while game isn't over
            while (!gameOver)
            {   // Print the current area to the screen
                DisplayCurrentArea();
                //if the player lost or beat the game
                if (playerIsAlive == false || currentArea ==3)
                {//Print the main menu
                    DisplayMainMenu();
                }

               else
                {   //increment the current area
                    currentArea++;
                }
            }


            string stats;

            void intro()
            {
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
                        health = 120;
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
            }
           

            void Encounters1And2()
            {
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

                //encounter 2
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
                        speed += 20;
                        break;
                    }

                    Console.WriteLine("Your perception is off a little their boy my speed is 50." + "\n You were no match for him!");
                    health -= 30;
                }


                Console.ReadLine();
                Console.Clear();
            }

            
            void Village()
            {
                string name = "Empty";
                //the village
                Console.WriteLine("Welcome to the village of Bertane Im the town's Marshal you can call me by Will." + "\n If you keep walking you'll find the town saloon.");
                Console.WriteLine("We have a Quest Giver at the Saloon");
                Console.ReadKey();
                Console.Clear();
                //town's saloon
                Console.WriteLine("Walking down the road you approuch the towns saloon." + "\n You find out that the bar keep is the towns Quest Giver.");
                Console.WriteLine("You ask the bar keep if there are any quest that I can take?" + "\n Hi sir my name is Dave would you like to accept a quest?");
                Console.WriteLine("Now that you have accepted this quest I would like you to talk to the shop keep at the end of the town she will tell you the rest.");
                Console.WriteLine("You take the quest and walk down to the Fence to get directions.");

                Console.ReadKey();
                Console.Clear();
                //town's shop
                Console.WriteLine("You approach the fence where the shop keep greets you." + "\n Weclome to the fence we have all you needs you may call me Shela.");
                Console.WriteLine("Lots of people been telling me that your a travler but for my view you don't look the part." + "\n She gives you an upgraded weapon!");
                damage += 30;
                Console.WriteLine("With that you should have no problem with your quest.");

                Console.Clear();
                //show stats
                Console.WriteLine("Your Charcater Stats\n");
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Class " + characterClass);
                Console.WriteLine("Health " + health);
                Console.WriteLine("Power " + damage);
                Console.WriteLine("Range " + range);
                Console.WriteLine("Speed " + speed);

                Console.ReadKey();
                Console.Clear();

                //quest information
                Console.WriteLine("The quest is to kill a pack of wolves that have been recently been causing trouble with our cattle.");
                Console.WriteLine("To get to their den you walk east an cross over a river and their should be a cave near their.");
                Console.WriteLine("You start your trip but Shela grabs you and gives you better clothes." + "\n Sorry I forgot to give you this now you're set.");
                health += 50;

                if (health <= 0)
                {
                    Console.WriteLine("HaHa! You died fool!");
                    playerIsAlive = false;
                    return;

                }

                Console.ReadKey();
                Console.Clear();
            }

            void quest()
            {
                //quest journey
                Console.WriteLine("You thank her and walk east allong the way you find rusty bullets." + "\n Knowing that this might be a big fight you take your time getting their.");
                Console.WriteLine("You walk along the wood bridge and you cant seem to find the cave!" + "\n Pushing over a large rock that was standing out their appears to be a cave underneath!");
                //first cave fight
                Console.WriteLine("You ready yourself and enter the cave!" + "\n You light a stick and see that their are a 3 wolves infront of you!");

                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("You attack the closest wolf strinking a fatail blow!" + "\n You kick the dead wolf into the 2 wolves left");
                Console.WriteLine("The wolves charge at us getting in some bit while I attack both of them!");
                health -= 40;

                Console.WriteLine("Kicking the wolves off you and stricking them again for good measure." + "\n you find a chest past them and inside their is a hat");
                range += 15;

                Console.ReadKey();
                Console.Clear();
                //Second cave fight
                Console.WriteLine("You hear strange noise to the left path!" + "\n You head into the left path and find a strange man that is calling upon something.");
                Console.WriteLine("The man finishes his spell and it summons 3 wolves." + "\n The wolves smell around and find you and the man laughs and heads deeper into the cave.");
                Console.Clear();

                Console.WriteLine("The wolves all sink their jaws into your arms and legs!" + "You jab one of them off and throw the rest at the first one.");
                health -= 40;
                Console.WriteLine("You throw the torch at the wolves catching their furr on fire!");
                Console.WriteLine("The last wolf lunges at you and gets one last bite before dying to the fire!");
                health -= 40;

                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Knowing that you will have to fight that strange man you check your stats.");
                Console.Clear();

                string name = "";
                //show stats
                Console.WriteLine("Your Charcater Stats\n");
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Class " + characterClass);
                Console.WriteLine("Health " + health);
                Console.WriteLine("Power " + damage);
                Console.WriteLine("Range " + range);
                Console.WriteLine("Speed " + speed);

                if (health <= 0)
                {
                    Console.WriteLine("HaHa! You died fool!");
                    playerIsAlive = false;
                    return;

                }

            }

            void questBoss()
            {
                Console.WriteLine("You enter a large open cave room where the man is standing in the middle of a ring of light!");
                Console.WriteLine("You watch to see what he is doing and this seems to be something worse last time then a bright light flashes!");
                Console.WriteLine("A large beast shadow appears towering over the man!" + "\n 1. You can charge in head first against the beast" + "\n 2. use a blits spell to attack the man");

                input = Console.ReadLine();

                if (input == "1")
                {
                    
                    Console.WriteLine("You jump over the rocks and run up to the beast landing a dropkick!" + "\n You are swiped away and relize that this might be a bad idea.");
                    health -= 60;
                    Console.WriteLine("You might have one trick up your sleave to might defeat the beast." + "You use the potion to heal yourself and you feel a surge of power!");
                    health = 150; damage += 100;
                    Console.WriteLine("Taking your weapon in with one mighty shot it drills a hole straight through the beast!");
                    Console.WriteLine("The man is in shock he drops to knees realizing that he was defeated");
                    Console.ReadKey();
                    Console.Clear();

                }

                else if (input == "2")
                {
                    string name = "";
                    Console.WriteLine("You legs starts glowing and you make sure that your aim is right and dash into the man landing a brutral dropkick sending the man flying!");
                    Console.WriteLine("The man steps back up and comands the beast to attack and you get swiped across the room and breaking through a rock ");
                    health -= 60;
                    Console.WriteLine("The beast tries using a rock as a basketball and slams it down on name");
                    health -= 200;
                    Console.Clear();
                }

                else
                {
                    //...display error message
                    Console.WriteLine("Invalid Input");
                }

                if (health <= 0)
                {
                    Console.WriteLine("HaHa! You died fool!");
                    playerIsAlive = false;
                    return;

                }

                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("You take the cative and bring him back to the town's marshal");
                Console.WriteLine("Thank you for ending the wolves rain of terror on the village and the man will be put on trial!");
                Console.WriteLine("All the villagers come out of their home and rejoice with guns blazing!");


            }


           












        }
    }
}
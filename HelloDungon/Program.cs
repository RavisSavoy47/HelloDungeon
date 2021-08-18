using System;

namespace HelloDungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new instance of Game
            Game game = new Game();

            //Intitalize default health values
            int healthRegen = 50;
            int health = 100 / 2;
            //Increase health by regen amount
            health += healthRegen;
            Console.WriteLine(health);

            int currectArea = 1;
            float damage = 10;
            float speed = 5;
            float range = 5;

            bool gameOver = false;
            //Mana 
            int mana = 100 / 2;
            int manaRegen = 50;
            mana += manaRegen;
            //Character Classes
            int Gunslinger;
            int Brute;
            
            //Run the Game
            game.Run();
        }
    }
}

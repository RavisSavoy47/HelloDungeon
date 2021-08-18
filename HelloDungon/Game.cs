using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDungeon
{
    class Game
    { 
        public void Run()
        {
            //Name exercise
            string name = "Empty";
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            string characterName = (name);
          
            //introduction
            Console.WriteLine("Weclome to Waistlands");
            Console.WriteLine("This is a place ware you forge your own path");
            //class selection
            Console.WriteLine("What class would you like to choose");
            Console.WriteLine("Choose between. Gunslinger or Brute");
            string characterClass = Console.ReadLine();
           //test
          




        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            float health = 100.0f;
            float healthRegen = 20.0f;
            bool ready = true;
            int level = 1;
            //^stats^\\
            Console.WriteLine("You there, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine(name + ". That's a good name.");
            Console.WriteLine("So " + name +", what is your role?");
            string role = Console.ReadLine();
            Console.WriteLine("Do you have a companion? What is their name?");
            string compn = Console.ReadLine();
            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Role: " + role);
            Console.WriteLine("Level: " + level);
            Console.WriteLine("Your companion " + compn + " is waiting.");
        }
    }
}

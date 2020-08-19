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
            string role = "Boring";
            int level = 1;
            float mana = 30.0f;
            //^stats^\\
            Console.WriteLine("You there, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine(name + ". That's a good name.");
            Console.WriteLine("So " + name +", what is your class?");
            Console.WriteLine("select class: 1. Mage 2. Knight");
            char input = Console.ReadKey().KeyChar;
            if (input == '1')
            {
                role = "Mage";
                health = 50;
                mana = 60;
            }
            else if (input == '2')
            {
                role = "Knight";
                health = 150;
                mana = 15;
            }
            else
            {
                Console.WriteLine("invalid input, using default stats.");
            }
            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Role: " + role);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Mana: " + mana);
            Console.WriteLine("Level: " + level);

            Console.WriteLine("your level have increased");
            for (int i = 0; i < 5; i++)
            {
                health++;
                mana++;
            }
            level++;
            Console.WriteLine(health + " " + mana + " " + level);
        }
    }
}
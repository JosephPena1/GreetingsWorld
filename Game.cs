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
            Console.WriteLine("So " + name +", what is your class?");
            Console.WriteLine("select class:");
            Console.WriteLine("1. Mage");
            Console.WriteLine("2. Knight");
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
            Console.WriteLine("press enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Nice to meet you " + name + ", I would stay to chat but I have important business.");
            Console.WriteLine("Oh, and Word of advise, there are bandits hiding around this forest.");
            Console.WriteLine("So stay low, and move quietly.");
            Console.WriteLine("1. move quietly 2. run aimlessly");
            char choice = Console.ReadKey().KeyChar;
            if (choice == '1')
            {
                Console.WriteLine("You sucessfully sneak out of the forest undetected");
            }
            else if (choice == '2')
            {
                Console.WriteLine("You run around randomly, then suddenly you feel a sharp pain in your arm.");
                health = health -= 5;
            }
            else
            {
                Console.WriteLine("you're so overwhelmed by the choices you curl up on the ground and cry.");
                Console.WriteLine("sadness: 100");
            }
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
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            float maxHealth = 0.0f;
            float health = 100.0f;
            string role = "";
            int level = 1;
            float maxMana = 30.0f;
            float mana = 30.0f;
            int damage = 0;
            //^stats^\\
            float banditHealth = 100.0f;
            int banditDmg = 10;
            //^enemies^\\
            void levelUp()
            {
                Console.WriteLine("your level have increased");
                for (int i = 0; i < 5; i++)
                {
                    maxHealth++;
                    maxMana++;
                }
                level++;
                Console.WriteLine("Max Health: " + maxHealth);
                Console.WriteLine("Max Mana: " + maxMana);
                Console.WriteLine("Level: " + level);
            }
            void battle()
            {
                while(health != 0 && banditHealth != 0)
                {
                    char move = Console.ReadKey().KeyChar;
                    Console.WriteLine("your turn.");
                    Console.WriteLine("1. Punch");
                    Console.WriteLine("2. Cast spell");
                    while (move != '1' && move != '2')
                    {
                        move = Console.ReadKey().KeyChar;
                        if (move == '1')
                        {
                            banditHealth = banditHealth - damage;
                        }
                        else if (move == '2')
                        {
                            move = '0';
                            Console.WriteLine("Which spell will you use?");
                            while (move != '1' && move != '2')
                            {
                                if (move == '1')
                                {
                                    //healing spell
                                }
                                else if(move == '2')
                                {
                                    //damage spell
                                }
                            }
                        }
                    }
                }
            } //WIP
            //^levelup function^\\
            Console.WriteLine("You there, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("So " + name +", what is your class?");
            Console.WriteLine("select class:");
            Console.WriteLine("1. Mage");
            Console.WriteLine("2. Knight");
            char input = ' ';
            while(input != '1' && input != '2')
            {
                input = Console.ReadKey().KeyChar;
                if (input == '1')
                {
                    role = "Mage";
                    maxHealth = 50;
                    health = 50;
                    maxMana = 60;
                    mana = 60;
                }
                else if (input == '2')
                {
                    role = "Knight";
                    maxHealth = 150;
                    health = 150;
                    maxMana = 15;
                    mana = 15;
                }
                else
                {
                    Console.WriteLine("invalid input.");
                }
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
                Console.WriteLine("You run around hopeing to find a way out, then suddenly you feel an arrow pierce your leg.");
                health = health - 10;
                Console.WriteLine("Health: " + health);
                battle();
            }
            else
            {
                Console.WriteLine("you're not sure so you decide to camp out for a while.");
            }
            
        }
    }
}
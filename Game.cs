using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            bool gameOver = false;
            while (gameOver == false)
            {
                float maxHealth = 0.0f;
                float playerHealth = 100.0f;
                string role = "";
                int level = 1;
                float maxMana = 30.0f;
                float mana = 30.0f;
                string weapon = "Fists";
                int damage = 0;
                int speed = 0;
                //^stats^\\
                int banditHealth = 100;
                int banditDmg = 10;
                char enemyAction = '0';
                char action = '0';
                int currentEnemy = 0;
                //^battle^\\
                void LevelUp()
                {
                    Console.WriteLine("your level has increased");
                    for (int i = 0; i < 5; i++)
                    {
                        maxHealth++;
                        maxMana++;
                    }
                    level++;
                    Console.WriteLine("Max Health increased by 5!");
                    Console.WriteLine("Max Mana increased by 5!");
                    Console.WriteLine("Max Health: " + maxHealth);
                    Console.WriteLine("Max Mana: " + maxMana);
                    Console.WriteLine("Level: " + level);
                }
                void Healing()
                {
                    playerHealth = playerHealth + 20;
                    if (playerHealth > maxHealth)
                    {
                        playerHealth = maxHealth;
                        Console.WriteLine("you are fully healed");
                    }
                    else
                    {
                        Console.WriteLine("You healed 20 health.");
                    }
                }
                void Battle()
                {
                    Console.WriteLine("Bandit uses sword.");
                    playerHealth = playerHealth - banditDmg;
                    Console.WriteLine("You took " + banditDmg + " damage.");
                    Console.WriteLine("Health: " + playerHealth);
                }
                //^functions^\\
                Console.WriteLine("You there, what is your name?");
                string name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("What is your class?");
                Console.WriteLine("select class:");
                Console.WriteLine("[1] Mage");
                Console.WriteLine("[2] Knight");
                Console.WriteLine("[3] Rogue");
                char input = ' ';
                while (input != '1' && input != '2' && input != '3')
                {
                    input = Console.ReadKey().KeyChar;
                    if (input == '1')
                    {
                        role = "Mage";
                        maxHealth = 50;
                        playerHealth = 50;
                        maxMana = 60;
                        mana = 60;
                        weapon = "bubble beam";
                        damage = 5;
                        speed = 20;
                        Console.Clear();
                    }
                    else if (input == '2')
                    {
                        role = "Knight";
                        maxHealth = 150;
                        playerHealth = 150;
                        maxMana = 15;
                        mana = 15;
                        weapon = "Sword";
                        damage = 10;
                        speed = 10;
                        Console.Clear();
                    }
                    else if (input == '3')
                    {
                        role = "Rogue";
                        maxHealth = 25;
                        playerHealth = 25;
                        maxMana = 5;
                        mana = 5;
                        weapon = "Daggers";
                        damage = 20;
                        speed = 40;
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("invalid input.");
                    }
                }
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Role: " + role);
                Console.WriteLine("Health: " + playerHealth);
                Console.WriteLine("Mana: " + mana);
                Console.WriteLine("Damage: " + damage);
                Console.WriteLine("Speed: " + speed);
                Console.WriteLine("Level: " + level);
                Console.WriteLine("press enter to continue");
                Console.ReadLine();
                Console.Clear();
                while (playerHealth > 0)
                {
                    Console.WriteLine("Nice to meet you " + name + ", I am Mirmulnir");
                    Console.ReadKey();
                    Console.WriteLine("I know you have a lot of questions, but we really must get out of this forest.");
                    Console.ReadKey();
                    Console.WriteLine("I recommend staying low, and moving quietly.");
                    Console.ReadKey();
                    Console.WriteLine("Wouldn't want bandits to find us.");
                    Console.ReadKey();
                    Console.WriteLine("[1] move quietly");
                    Console.WriteLine("[2] run aimlessly");
                    input = '0';
                    while (input != '1' && input != '2')
                    {
                        input = Console.ReadKey().KeyChar;
                        if (input == '1')
                        {
                            Console.Clear();
                            Console.WriteLine("You sneak out of the forest undetected");
                            Console.WriteLine("Press any key");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (input == '2')
                        {
                            Console.Clear();
                            Console.WriteLine("You run around hopeing to find a way out, then suddenly you feel an arrow pierce your leg.");
                            playerHealth = playerHealth - 10;
                            Console.WriteLine("Health: " + playerHealth);
                            Console.WriteLine("You look up to see a bandit running towards you, sword in hand.");
                            Console.WriteLine("Press any key");
                            Console.ReadKey();
                            Console.Clear();
                            while (playerHealth > 0 && banditHealth > 0)
                            {
                                Console.WriteLine("Bandit health: " + banditHealth);
                                Console.WriteLine("What do you do?");
                                Console.WriteLine("1. attack");
                                Console.WriteLine("2. heal");

                                input = '0';
                                while (input != '1' && input != '2')
                                {
                                    input = Console.ReadKey().KeyChar;
                                    if (input == '1')
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You use " + weapon);
                                        banditHealth = banditHealth - damage;
                                        Console.WriteLine("Bandit took " + damage + " damage.");
                                        Console.WriteLine("Press any key to end turn.");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else if (input == '2')
                                    {
                                        Console.Clear();
                                        Healing();
                                        Console.WriteLine("Press any key to end turn.");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        Console.WriteLine("invalid input, using default attack");
                                    }
                                }
                                Battle();
                                Console.WriteLine("Press any key for your turn");
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }
                    }
                    LevelUp();
                    Console.WriteLine("You win!");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    gameOver = true;
                    break;
                }
            }
        }
    }
}
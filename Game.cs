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
            float healthRegen = 20;
            Console.WriteLine("You there, what is your name?");
            string name = Console.ReadLine();
            bool ready = true;
            int level = 1;
            Console.WriteLine(health);
            health = health + healthRegen;
            Console.Write(name + " healed " + healthRegen + " health");
        }
    }
}

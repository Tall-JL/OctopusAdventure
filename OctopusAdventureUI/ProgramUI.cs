using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctopusAdventureUI
{
    public class ProgramUI
    {
        int PlayerHealth = 100;

        public void Run()
        {
            GameStart();
        }

        public void GameStart()
        {
            bool alive = true;
            
            while (alive)
            {
                Console.Clear();
                Console.WriteLine("You are are a little octopus that woke up in a strange place. You have no idea how you got there" +
                    " or how you will get back home. This is the story of one octopi's tumultuous journey to find his way home.\n\n" +
                    "Lets see if you make it!\n\n\n\n");
                Console.ReadKey();


                Console.Clear();
                Console.WriteLine("Where am I? How did I get here? This isnt where I went to sleep... What in the ocean could have happened? I need to get out of here." +
                    "I need to get home.\n\n\n" +
                    "I need to get home...\n\n\n\n\n\n" +
                    "***Press 1 to continue***");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        StartingWorld1();
                        break;
                    default:
                        GameStart();
                        break;

                }
                if (PlayerHealth <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("You close your eyes for the last time.");
                    Console.ReadKey();
                    alive = false;
                }
            }
        }


        public void StartingWorld1() 
        {
            NewZone("You wake to see yourself in a strange area. You look around and notice you only see a couple things. Close to " +
                "you, you see a current move pretty fast. If you jump in this no doubt you'll get a kick start on your journey. Looking below you see a " +
                "lump in the sand. What should your first move be?\n\n\n" +
                "You decide to RIDE the current.\n" +
                "You have to SEARCH that sand bump!\n" +
                "You decide to SWIM ABOVE the current.");

            string command = Console.ReadLine().ToLower();

            if (true)
            {

            }
        }
        public void StartingWorld2() { }
        public void JellyFish() { }
        public void Sky() { }
        public void Turtle1() { }
        public void Turtle2() { }
        public void Shark1() { }
        public void Shark2() { }
        public void Tunnel() { }
        public int DamageTaken(int damage) 
        {
            var damaged = PlayerHealth - damage;
            Console.WriteLine($"Health: {damaged}/100");
            return damaged;
        }
        public int HealHealth(int heal) 
        {
            var healed = PlayerHealth + heal;
            Console.WriteLine($"Health: {healed}/100");
            return healed;
        }
        public string NewZone(string splash)
        {
            Console.Clear();
            Console.WriteLine(splash);
            return splash;
        }
        public int Poison(int damage)
        {
            Random poison = new Random();
            var poisoned = PlayerHealth - poison.Next(0,damage);
            Console.WriteLine($"Health: {poisoned}/100");
            return poisoned;
        }
        


    }
}

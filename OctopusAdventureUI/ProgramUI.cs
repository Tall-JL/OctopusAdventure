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
                    "I need to get home. \n\n\n" +
                    "I need to get home...\n\n\n\n" +
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
                "You decide to SWIM ABOVE the current.\n\n\n");

            string command = Console.ReadLine().ToLower();

            if (command == "ride")
            {
                Console.WriteLine("You ride the warm water current further south but you are spit out in a area you weren't expecting!");
                Console.ReadKey();
                JellyFish();
            }
            else if (command == "search")
            {
                Console.WriteLine("As you're digging around you find something rough to the touch. Its a shell! " +
                    "Shells are great for protection!");
                HealHealth(20);
                Console.ReadKey();
                StartingWorld1();
            }
            else if (command == "swim above")
            {
                Console.WriteLine("After swimming high enough to avoid the current you are suddenly snatch into the air by a seagull!");
                Console.ReadKey();
                Sky();
            }
            else
            {
                InvalidCommand();
                StartingWorld1();
            }          
                        
        }
        public void StartingWorld2() 
        {
            NewZone("You dont see anything else to search for. What should you do now? \n\n\n" +
                "You decide to RIDE the current.\n" +
                "You decide to SWIM ABOVE the current.\n\n\n");

            string command = Console.ReadLine().ToLower();

            if (command == "ride")
            {
                Console.WriteLine("You ride the warm water current further south but you are spit out in a area you weren't expecting!");
                Console.ReadKey();
                JellyFish();
            }
            
            else if (command == "swim above")
            {
                Console.WriteLine("After swimming high enough to avoid the current you are suddenly snatch into the air by a seagull!");
                Console.ReadKey();
                Sky();
            }
            else
            {
                InvalidCommand();
                StartingWorld2();
            }
        }
        public void JellyFish() 
        {
            NewZone("The current spits you out fairly roughly. As you begin to look at your new surroundings you notice a jellyfish moving toward you. It's" +
                "moving faster than you've seen most jellyfish move and realize it's because the current carried it there too. You turn around and to your surprise you see " +
                "several more jellyfish. The current must have carried an entire group of them here and you fell out in the middle!! You have to get out of here " +
                "before the jellyfish catch you in their stingers!\n\n\n" +
                "Try to OUTSWIM them?\n" +
                "Use your long tentacles to PUSH them down?\n" +
                "SEARCH the sand below for a tool to use for escape?\n\n\n");

            string command = Console.ReadLine().ToLower();

            if (command == "outswim")
            {
                Console.WriteLine("You jolt away but you cant outmanuever them all and get caught in their stingers! You unravel yourself and swim away hurt and -POISONED-...");
                Poison(15);
                Console.ReadKey();
                Turtle1();
            }
            else if (command == "push")
            {
                Console.WriteLine("With the grace of a dancer you jolt up and start pushing the jellyfish down, giving you room to bounce from one" +
                    "top to the next safely and quickly!");                
                Console.ReadKey();
                Turtle1();
            }
            else if (command == "search")
            {
                Console.WriteLine("You attempt to drop below to search for something, anything! But the jellyfish tentacles were longer than you thought." +
                    " You get hurt by even more of their stings. You unravel yourself and swim away hurt and -POISONED-...");
                Poison(25);
                Console.ReadKey();
                Turtle1();
            }
            else
            {
                InvalidCommand();
                JellyFish();
            }
        }
        public void Sky() 
        {
            NewZone("A seagull has got you by its beak and is carrying you through the air! You cant tell which direction it's going but you know you have to escape! " +
                "How can you get out of this?\n\n\n" +
                "Try to STRUGGLE your way out of its grasp?\n" +
                "No bird is going to stop go, STRANGLE it!\n" +
                "It thinks its the only with a beak? Show it yours! BITE!\n\n\n");

            string command = Console.ReadLine().ToLower();

            if (command == "struggle")
            {
                Console.WriteLine("After struggling for some time the bird finally drops you. Unfortunately you hit to water....hard");
                DamageTaken(10);
                Console.ReadKey();
                Shark1();
            }
            else if (command == "strangle")
            {
                Console.WriteLine("Your other 7 muscular arms reach up and start choking the birds neck! It eventually opens its beak and starts to fall" +
                    " to the water due to lightheadedness. You both hit the water hard.");
                DamageTaken(10);
                Console.ReadKey();
                Shark1();
            }
            else if (command == "bite")
            {
                Console.WriteLine("After grabbing hold of the birds head you pull yourself up and with a swift downward thrust you bite its eye with your beak! " +
                    "the seagull reels in pain and falls from the sky. You both hit the water hard.");
                DamageTaken(10);
                Console.ReadKey();
                Shark1();
            }
            else
            {
                InvalidCommand();
                Sky();
            }
        }
        public void Turtle1() 
        {
            NewZone("Having finally gotten away from those jellyfish you think you have a moment to breath.\n\n\n");

            string command = Console.ReadLine().ToLower();

            if (command == "struggle")
            {
                Console.WriteLine("After struggling for some time the bird finally drops you. Unfortunately you hit to water....hard");
                DamageTaken(10);
                Console.ReadKey();
                Shark1();
            }
            else if (command == "strangle")
            {
                Console.WriteLine("Your other 7 muscular arms reach up and start choking the birds neck! It eventually opens its beak and starts to fall" +
                    " to the water due to lightheadedness. You both hit the water hard.");
                DamageTaken(10);
                Console.ReadKey();
                Shark1();
            }
            else if (command == "bite")
            {
                Console.WriteLine("After grabbing hold of the birds head you pull yourself up and with a swift downward thrust you bite its eye with your beak! " +
                    "the seagull reels in pain and falls from the sky. You both hit the water hard.");
                DamageTaken(10);
                Console.ReadKey();
                Shark1();
            }
            else
            {
                InvalidCommand();
                Sky();
            }
        }
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
        public void InvalidCommand()
        {
            Console.WriteLine("Please enter one of the capitalized commands");
            Console.ReadKey();
        }
        public int Poison(int damage)
        {
            Random poison = new Random();
            int poisonDamage = poison.Next(0, damage);
            var poisoned = PlayerHealth - poisonDamage;
            Console.WriteLine($"You took {poisonDamage} poison damage!");
            Console.WriteLine($"Health: {poisoned}/100");
            return poisoned;
        }
        


    }
}

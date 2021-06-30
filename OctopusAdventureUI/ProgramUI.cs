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
        bool alive = true;
        public void GameStart()
        {


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
                StartingWorld2();
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
            NewZone("Having finally gotten away from those jellyfish you think you have a moment to breath. You look around to see a turtle. A hungry turtle!" +
                "If its not one things its another trying to take your life. Its just one turtle luckily so what how will you handle this one?\n\n\n" +
                "You decide the best approach is the aggressive approach! So you ATTACK!\n" +
                "Lets not forget you are an octopus and can INK it!" +
                "You see something shiny close by, PICK it up?\n\n\n");

            string command = Console.ReadLine().ToLower();

            if (command == "attack")
            {
                Console.WriteLine("You hit the turtle with a flurry of octo-punches! They did absolutely nothing to the turtle. So little so you confused the " +
                    "turtle for a moment.");

                Console.ReadKey();
                Turtle2();
            }
            else if (command == "ink")
            {
                Console.WriteLine("You use what the good Poseidon gave you and inked the turtle but the turtle is a natural predator of yours and " +
                    "shook off the ink immediately took a bite out of one of your arms. You use the time it takes to eat it to escape...");
                DamageTaken(30);
                Console.ReadKey();
                Shark1();
            }
            else if (command == "pick")
            {
                Console.WriteLine("You search the shiny object quickly thanks to your agility. You pull it out and it turns out it was.....A KNIFE?!?" +
                    "You hold the knife up at the turtle and it reaches up as to say it doesnt want any beef before swimming away. You feel powerful and that" +
                    "adrenaline retores of you vigor!!");
                HealHealth(30);
                Console.ReadKey();
                Shark1();
            }
            else
            {
                InvalidCommand();
                Turtle1();
            }
        }
        public void Turtle2()
        {
            NewZone("The turtle having been confused briefly didnt attack immediately but catches its bearings and prepares itself to not let you get away with that!" +
                " The turtle is riled up and charges you! How do you react?\n\n\n" +
                "You are on a roll so ATTACK again!\n" +
                "Use this chance to INK it!\n\n\n");

            string command = Console.ReadLine().ToLower();

            if (command == "attack")
            {
                Console.WriteLine("The turtle wont fall for that a second time so as you reach out to hit attack it bites your tentacle off and you use the time it takes to eat" +
                    "it as escape time");
                DamageTaken(30);
                Console.ReadKey();
                Shark1();
            }
            else if (command == "ink")
            {
                Console.WriteLine("Since the turtle was rushing the ink was highly effect and blinding it from its rushing path and you successfully escape!");

                Console.ReadKey();
                Shark1();
            }

            else
            {
                InvalidCommand();
                Turtle2();
            }
        }
        public void Shark1()
        {
            NewZone("You were happy to be through with that ordeal and before you can even figure out where you are you notice some huge swimming at you and fast. Most likely brought " +
                "on by all the commotion you left. Its the huge creature comes into place you notice its the worst thing youve seen yet." +
                "A SHARK!!!! Theres no way you can out run a shark so you have to do something...\n\n\n" +
                "You decide its time to go on the offensive and ATTACK the shark!\n" +
                "You can fight that tank with teeth...You attempt to HIDE in the sand below!\n\n\n");

            string command = Console.ReadLine().ToLower();

            if (command == "attack")
            {
                Console.WriteLine("You ball all your tentacles up into giant fist and with as much strength as you can muster you hit the shark with all your " +
                    "might and it did......absolutely nothing! The shark bites your mass of arms and shakes you to the side. Youre free to go but at what cost...");
                DamageTaken(50);
                Console.ReadKey();
                Breather();
            }

            else if (command == "hide")
            {
                Console.WriteLine("You manage to hit the sand in just the brink of time! The shark crashes into the sand bank and nudged the sand to get you out but to no" +
                    "avail! While you are in the sand you find a wierd colored shrimp and seemed to be pulsing. You love shrimp so you hold onto it. The shark leaves...");
                Console.ReadKey();
                Shark2();
            }
            else
            {
                InvalidCommand();
                Shark1();
            }
        }

        public void Shark2()
        {
            NewZone("You emerge from the sand to see that the shark is finally gone. Happily with your escape you go swimming about your way!" +
                "Unfortunately without you noticing you see three creatures quickly surround you. Its the shark you just escaped and 2 more sharks with it!" +
                "Its over. Theres no way you can fight 3 sharks. You have little choices here...\n\n\n" +
                "Your agility is a sight to behold so you try to RUN away from them!\n" +
                "You figure if you are going to die you might as well die full and EAT the weird shrimp you found...\n\n\n");

            string command = Console.ReadLine().ToLower();

            if (command == "run")
            {
                Console.WriteLine("You try with all your might to zip and zap the 3 sharks but its too much. They catch you and make sure you never swim again. You've become" +
                    " food for the circle of life...");
                DamageTaken(10000);
                Console.ReadKey();
                
            }

            else if (command == "hide")
            {
                Console.WriteLine("You eat the shrimp and suddenly you start to feel strange. You start pulsing and growing? You suddenly sprout up to a size that makes the " +
                    "sharks look like ants starting at a skyscraper!!! YOU ARE THE COLOSSAL OCTOPUS!!! You grab the 3 sharks with your tentacles! You hold the shark who chased you first" +
                    " down and begin to use the other two sharks to beat the first shark like an expert drummer playing a solo! You beat them with such fury and rage that once your done" +
                    " there is nothing but chunks of meat corpses that are hardly recognizable. Tired your body begins to shrink again. Having managed to deal with this threat" +
                    " you make continue to make your way in another direction.");
                Console.ReadKey();
                Breather();
            }
            else
            {
                InvalidCommand();
                Shark2();
            }
        }
        public void Breather()
        {

        }
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

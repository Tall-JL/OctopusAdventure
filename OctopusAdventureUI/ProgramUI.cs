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
                Console.WriteLine("Where am I? How did I get here? This isnt where I went to sleep... What in the ocean could have happened? I need to get out of here. " +
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
                "you, you see a current moving pretty fast. If you jump in this no doubt you'll get a kick start on your journey. Looking below you see a " +
                "lump in the sand. What should your first move be?\n\n\n" +
                "You decide to RIDE the current.\n" +
                "You have to SEARCH that sand bump!\n" +
                "You decide to SWIM ABOVE the current.\n\n\n");

            string command = Console.ReadLine().ToLower();

            if (command == "ride")
            {
                Console.WriteLine("\n\nYou ride the warm water current further south but you are spit out in a area you weren't expecting!");
                Console.ReadKey();
                JellyFish();
            }
            else if (command == "search")
            {
                Console.WriteLine("\n\nAs you're digging around you find something rough to the touch. Its a shell! " +
                    "Shells are great for protection!");
                HealHealth(20);
                Console.ReadKey();
                StartingWorld2();
            }
            else if (command == "swim above")
            {
                Console.WriteLine("\n\nAfter swimming high enough to avoid the current you are suddenly snatch into the air by a seagull!");
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
                Console.WriteLine("\n\nYou ride the warm water current further south but you are spit out in an area you weren't expecting!");
                Console.ReadKey();
                JellyFish();
            }

            else if (command == "swim above")
            {
                Console.WriteLine("\n\nAfter swimming high enough to avoid the current you are suddenly snatched into the air by a seagull!");
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
            NewZone("The current spits you out roughly. As you begin to look at your new surroundings you notice a jellyfish moving toward you. It's" +
                "moving faster than you've seen most jellyfish move and realize it's because the current carried it there too. You turn around and to your surprise you see " +
                "several more jellyfish. The current must have carried an entire group of them here and you fell out in the middle!! You have to get out of here " +
                "before the jellyfish catch you in their stingers!\n\n\n" +
                "Try to OUTSWIM them?\n" +
                "Use your long tentacles to PUSH them down?\n" +
                "SEARCH the sand below for a tool to use for escape?\n\n\n");

            string command = Console.ReadLine().ToLower();

            if (command == "outswim")
            {
                Console.WriteLine("\n\nYou jolt away but you cant outmanuever them all and get caught in their stingers! You unravel yourself and swim away hurt and -POISONED-...");
                Poison(16);
                Console.ReadKey();
                Turtle1();
            }
            else if (command == "push")
            {
                Console.WriteLine("\n\nYou swim up above the jellyfish but not before bumping a few stingers and become -POISONED-. Once above you begin to push down the jellyfish, giving you ample" +
                    "room to begin to move unobstructed!");
                Poison(10);
                Console.ReadKey();
                Turtle1();
            }
            else if (command == "search")
            {
                Console.WriteLine("\n\nYou attempt to drop below to search for something, anything! But the jellyfish tentacles were longer than you thought." +
                    " You get hurt by even more of their stings. You unravel yourself and swim away hurt and -POISONED-...");
                Poison(36);
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
                "No bird is going to stop you, STRANGLE it!\n" +
                "It thinks its the only with a beak? Show it yours! BITE!\n\n\n");

            string command = Console.ReadLine().ToLower();

            if (command == "struggle")
            {
                Console.WriteLine("\n\nAfter struggling for some time the bird finally drops you. Unfortunately you hit to water....hard");
                DamageTaken(10);
                Console.ReadKey();
                Shark1();
            }
            else if (command == "strangle")
            {
                Console.WriteLine("\n\nYour other 7 muscular arms reach up and start choking the birds neck! It eventually opens its beak and starts to fall" +
                    " to the water due to lightheadedness. You both hit the water hard.");
                DamageTaken(10);
                Console.ReadKey();
                Shark1();
            }
            else if (command == "bite")
            {
                Console.WriteLine("\n\nAfter grabbing hold of the birds head you pull yourself up and with a swift downward thrust you bite its eye with your beak! " +
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
                "Lets not forget you are an octopus and can INK it!\n" +
                "You see something shiny close by, PICK it up?\n\n\n");

            string command = Console.ReadLine().ToLower();

            if (command == "attack")
            {
                Console.WriteLine("\n\nYou hit the turtle with a flurry of octo-punches! They did absolutely nothing to the turtle. So little so you confused the " +
                    "turtle for a moment.");
                Poison2(20);
                Console.ReadKey();
                Turtle2();
            }
            else if (command == "ink")
            {
                Console.WriteLine("\n\nYou use what the good Poseidon gave you and inked the turtle but the turtle is a natural predator of yours and " +
                    "shook off the ink immediately and took a bite out of one of your arms. You use the time it takes to eat your arm to escape...");
                Poison2(20);
                DamageTaken(30);
                Console.ReadKey();
                Shark1();
            }
            else if (command == "pick")
            {
                Console.WriteLine("\n\nYou search for the shiny object quickly thanks to your agility. You pull it out and it turns out it was.....A KNIFE?!?" +
                    "You hold the knife up at the turtle and it reaches its flippers into the air as to say it doesnt want any beef before swimming away. You feel powerful and that" +
                    "adrenaline retores some of you vigor!!");                
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
            NewZone("The turtle having been confused briefly didnt attack immediately but catches its bearings and prepares itself to not let you get away with that again!" +
                " The turtle is riled up and charges you! How do you react?\n\n\n" +
                "You are on a roll so ATTACK again!\n" +
                "Use this chance to INK it!\n\n\n");

            string command = Console.ReadLine().ToLower();

            if (command == "attack")
            {
                Console.WriteLine("\n\nThe turtle wont fall for that a second time so as you reach out to attack it bites your tentacle off and you use the time it takes to eat" +
                    "it as escape time");
                DamageTaken(30);
                Console.ReadKey();
                Shark1();
            }
            else if (command == "ink")
            {
                Console.WriteLine("\n\nSince the turtle was rushing the ink was highly effective and blinded it from its rushing path and you successfully escape!");
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
            NewZone("You were happy to be through with that ordeal and before you can even figure out where you are you notice something huge swimming at you and fast. Most likely brought " +
                "on by all the commotion. As the huge creature comes into view you notice it's the worst thing you've seen yet." +
                "A SHARK!!!! There's no way you can out run a shark so you have to do something...\n\n\n" +
                "You decide its time to go on the offensive and ATTACK the shark!\n" +
                "You cant fight that tank with teeth...You attempt to HIDE in the sand below!\n\n\n");

            string command = Console.ReadLine().ToLower();

            if (command == "attack")
            {
                Console.WriteLine("\n\nYou ball all your tentacles up into giant fist and with as much strength as you can muster you hit the shark with all your " +
                    "might and it did......absolutely nothing! The shark bites your mass of arms and shakes you to the side. Youre free to go but at what cost...");
                DamageTaken(50);
                Console.ReadKey();
                Breather();
            }

            else if (command == "hide")
            {
                Console.WriteLine("\n\nYou manage to hide the sand in just in the brink of time! The shark crashes into the sand bank and nudges the sand to get you out but to no" +
                    "avail! While you are in the sand you find a wierd colored shrimp and it seems to be pulsing. You love shrimp so you hold onto it. The shark leaves...");
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
            NewZone("You emerge from the sand to see that the shark is finally gone. Happy with your escape you go swimming about your way!" +
                "Unfortunately without you noticing you see three creatures quickly surround you. Its the shark you just escaped and 2 more sharks with it!" +
                "Its over. Theres no way you can fight 3 sharks. You have little choices here...\n\n\n" +
                "Your agility is a sight to behold so you try to RUN AWAY from them!\n" +
                "You figure if you are going to die you might as well die full and EAT the weird shrimp you found...\n\n\n");

            string command = Console.ReadLine().ToLower();

            if (command == "run away")
            {
                Console.WriteLine("\n\nYou try with all your might to zip and zag the 3 sharks but its too much. They catch you and make sure you never swim again. You've become" +
                    " food for the circle of life...");
                DamageTaken(10000);
                Console.ReadKey();

            }

            else if (command == "hide")
            {
                Console.WriteLine("\n\nYou eat the shrimp and suddenly you start to feel strange. You start pulsing and growing? You suddenly sprout up to a size that makes the " +
                    "sharks look like ants staring at a skyscraper!!! YOU ARE THE COLOSSAL OCTOPUS!!! You grab the 3 sharks with your tentacles! You hold the shark who chased you first" +
                    " down and begin to use the other two sharks to beat the first shark like an expert drummer playing a solo! You beat them with such fury and rage that once your done" +
                    " there is nothing but hardly recognizable corpses. Tired, your body begins to shrink again. Having managed to deal with this threat" +
                    " you continue to make your way in another direction.");
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
            NewZone("The chances of you surviving an encounter with a shark were almost zero but yet you are still here. Whether it be luck or skill" +
                " you have persevered. You take some time to rest and compose yourself. You need to find your way home so which way should you continue? There seems to " +
                "be an area with a light not to far to your left and to your right there seems to be slight movement but you cant quite make out what it is.\n\n\n" +
                "Lets try going LEFT.\n" +
                "RIGHT is obviously the right way!\n\n\n");

            string command = Console.ReadLine().ToLower();

            if (command == "left")
            {
                Console.WriteLine("\n\nYou decide to go check out the light in the distance in hope of finding a clue to where you are.");
                HealHealth(30);
                Console.ReadKey();
                Coral1();
            }

            else if (command == "right")
            {
                Console.WriteLine("\n\nMovement means maybe there is someone or thing you can use to figure out you location based on what is in this habitat!");
                HealHealth(30);
                Console.ReadKey();
                Whale();
            }
            else
            {
                InvalidCommand();
                Breather();
            }
        }
        public void Whale()
        {
            NewZone("You decided to check out the movement in the distance. As you swim closer you notice that you can no longer see past the object to either side." +
                " Suddenly the movement turns out to be extremely apparent to what it is! Its a blue whale! Whales arent normally hostile to you so this could be a great" +
                " chance to stick to its side and catch a ride!\n\n\n" +
                "Swim up and STICK to its side?\n" +
                "Its way too dangerous to approach this massive creature so you FLEE.\n" +
                "WAIT for it to pass you?\n\n\n");

            string command = Console.ReadLine().ToLower();

            if (command == "stick")
            {
                Console.WriteLine("\n\nAfter approaching the behemoth you realize you should have went toward its side instead of the front of it. " +
                    "The whale opens its mouth and swallows you whole!!!!");
                Console.ReadKey();
                Whale2();
            }
            else if (command == "flee")
            {
                Console.WriteLine("\n\nNoticing the severity of the situation you turn tail and speed away! You glance backwards as you see the whale open its mouth; " +
                    "had you not left when you did surely youd be whale food by now!");
                Console.ReadKey();
                Tunnel();
            }
            else if (command == "wait")
            {
                Console.WriteLine("\n\nYou've decided to not approach the whale and to leave it be. Unfortunately the whale didnt have the same plan. It closes the distance" +
                    " between you and opens its mouth and you are swallowed whole!");
                Console.ReadKey();
                Whale2();
            }
            else
            {
                InvalidCommand();
                Whale();
            }
        }
        public void Whale2()
        {
            NewZone("The whale shifts around quite a lot so you use your suckers to stablize yourself. " +
                "Its almost pitch black here but your eyes adjust rather quickly and you survery your surroundings. Inside this whale seems to be" +
                "small fish bits, a broken up pirate ship and the exit to the whales blow hole!\n\n\n" +
                "There is no way you arent EXPLORING this pirate ship!\n" +
                "You decide to ESCAPE while you can through the blowhole.\n" +
                "Maybe the fish bits have some use to you so you SEARCH them!\n\n\n");

            string command = Console.ReadLine().ToLower();

            if (command == "exploring")
            {
                Console.WriteLine("\n\nYou squiggle your way over to the wreckage of the pirate ship! Upon slapping around bits of wood you see a doll with a strangely" +
                    " long nose. You throw it. Under some more wood you find pirate swords!");
                Console.ReadKey();
                Whale3();
            }
            else if (command == "escape")
            {

                Console.WriteLine("\n\nYou decide to take the only smart option and escape through the blow hole! Unfortunately the blow hole was squeezed tight since " +
                    "the whale was still submerged so you had to squeeze out and hurt yourself in the process. You get out of the whale and keep swimming on your way...");
                DamageTaken(35);
                Console.ReadKey();
                Tunnel();
            }
            else if (command == "search")
            {
                Random rnd = new Random();
                int chances = rnd.Next(1, 4);
                switch (chances)
                {
                    case 1:
                        Console.WriteLine("\n\nYou waddle over to the pile of fish bites. As you come up to it you see something else is there! Its a crab! The crab while angry with your " +
                        "interuption starts clawing all around to get you! Several of the attacks hit you and one" +
                        " of the missed claw attempts hit the whales tongue and the whale subsequently spits both you and crab" +
                        "out. You both hit the sea floor pretty hard.");
                        DamageTaken(45);
                        Console.ReadKey();
                        Tunnel();
                        break;
                    case 2:
                        Console.WriteLine("\n\nYou waddle over to the pile of fish bites. As you come up to it you see something else is there! Its a crab! The " +
                        "crab doesnt notice you are there so you get close enough to eat some of the fish. The fish energizes you but the crab " +
                        "then notices you! The crab while angry with your " +
                        "interuption starts clawing all around to get you! One of the missed claw attempts hit the whales tongue and the whale subsequently spits both you and crab" +
                        "out. You both hit the sea floor pretty hard.");
                        HealHealth(20);
                        Console.ReadKey();
                        Tunnel();
                        break;
                    case 3:
                        Console.WriteLine("\n\nYou waddle over to the pile of fish bites. As you come up to it you see something else is there! Its a crab! The crab while angry with your " +
                        "interuption starts clawing all around to get you! One of the missed claw attempts hit the whales tongue and the whale subsequently spits both you and crab" +
                        "out. You both hit the sea floor pretty hard.");
                        DamageTaken(25);
                        Console.ReadKey();
                        Tunnel();
                        break;
                    default:
                        break;

                }
            }
            else
            {
                InvalidCommand();
                Whale2();
            }
        }
        public void Whale3()
        {
            NewZone("With you newly equipped pirate swords this whale should make light work to get out of! The only question that remains is how violent do you" +
                " want to get about this?\n\n\n" +
                "You to get MAD and slash the tongue!\n" +
                "Trying not to anger the whale much you POKE the tongue gently.\n\n\n");

            string command = Console.ReadLine().ToLower();

            if (command == "mad")
            {
                Console.WriteLine("\n\nYou have several pirate swords held in several of your arms and with pure fury and swiftness you rapidly unleash a flurry" +
                    " of sword swipes at the tongue of this beast! You dont let up and the whale opens its mouth and you speed out of the whale while leave your" +
                    "swords stuck in the whales tongue. You adrenaline from conqouring this ordeal has healed you some!");
                HealHealth(15);
                Console.ReadKey();
                Tunnel();
            }
            else if (command == "poke")
            {
                Console.WriteLine("\n\nAfter opting to take a slightly less aggressive path you poke the whales tongue several times. The whale eventually gets annoyed" +
                    " enough to spit you out but it spits you into the sea floor and you hit to ground pretty hard!");
                DamageTaken(25);
                Console.ReadKey();
                Tunnel();
            }

            else
            {
                InvalidCommand();
                Whale3();
            }
        }
        public void Coral1()
        {
            NewZone("Light means you are getting closer to the surface and you feel this would be the best way to continue forward to find your home!" +
                " Once you catch up to the light you find out that what you saw was a beautiful coral reef shimmering in the distance! This isnt your home but a coral reef" +
                " would be the perfect new place to call your home!\n\n\n" +
                "You decide to SEARCH the reef to see if it would be a good place to settle!\n" +
                "A corel reef this bright means it has to have attracted predators so you decide its best to LEAVE and look for your original home...\n\n\n");

            string command = Console.ReadLine().ToLower();

            if (command == "search")
            {
                Console.WriteLine("\n\nYou swim around for a bit then see a good nook that would be perfect for you! Quickly you decide to swim down and check it out. No sooner than" +
                    " you reach the entrance do 2 huge electric eels come out!");
                Console.ReadKey();
                Coral2();
            }
            else if (command == "leave")
            {
                Console.WriteLine("\n\nYou know that if the reef could attract you then it has to be able to attract nastier creatures too, so " +
                    "in order to avoid once again another confrontation you just pre-emptively leave even though it pains you to do so... ");
                Console.ReadKey();
                Tunnel();
            }

            else
            {
                InvalidCommand();
                Coral1();
            }
        }
        public void Coral2()
        {
            NewZone("Why cant you just have a simple life. All you wanted was a place to lay your mantle and here we are with yet another confrontation... You slowly back up from the " +
                "eels when suddenly one of them zips toward you fast with the intent to kill!!!!\n\n\n" +
                "There's no way INK wont work on these fools!\n" +
                "Electric eels are easily a match for you and especially with another one behind the charging one. You decide itd be best to quickly SWIM out of there.\n\n\n");

            string command = Console.ReadLine().ToLower();

            if (command == "ink")
            {
                Console.WriteLine("\n\nLuckily for you the eels were all bunched up from all being in the hole so when you went to spray your ink you got both of them! " +
                    "You escape out of there as quick as you can and leave the reef for good!");
                Console.ReadKey();
                Tunnel();
            }
            else if (command == "swim")
            {
                Console.WriteLine("\n\nLeaving was the best option you could think of but the eels range on their shock is really far! You get stunned and the eels begin to " +
                    "attack you. Unfortunatley you cant move thanks to the shock and there was nothing else you can do at this point. Your death is inevitable...");
                DamageTaken(1000);
                Console.ReadKey();
                
            }
            else
            {
                InvalidCommand();
                Coral2();
            }
        }
        public void Tunnel() { }
        public int DamageTaken(int damage)
        {
            ProgramUI newHealth = new ProgramUI();
            PlayerHealth = PlayerHealth - damage;
            Console.WriteLine($"You took {damage} damage!");
            Console.WriteLine($"Health: {PlayerHealth}/100");
            return PlayerHealth;
        }
        public int HealHealth(int heal)
        {
            ProgramUI newHealth = new ProgramUI();
            PlayerHealth = PlayerHealth + heal;
            Console.WriteLine($"You were healed by {heal}!");
            Console.WriteLine($"Health: {PlayerHealth}/100");
            return PlayerHealth;
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
            int poisonDamage = poison.Next(0, damage);
            PlayerHealth = PlayerHealth - poisonDamage;
            Console.WriteLine($"You took {poisonDamage} poison damage and will be poisoned next map!");
            Console.WriteLine($"Health: {PlayerHealth}/100");
            return PlayerHealth;
        }
        public int Poison2(int damage)
        {
            Random poison = new Random();
            int poisonDamage = poison.Next(0, damage - 10);
            PlayerHealth = PlayerHealth - poisonDamage;
            Console.WriteLine($"You took {poisonDamage} residual poison damage!");
            Console.WriteLine($"Health: {PlayerHealth}/100");
            return PlayerHealth;
        }
        public void InvalidCommand()
        {
            Console.WriteLine("Please enter one of the capitalized commands");
            Console.ReadKey();
        }



    }
}

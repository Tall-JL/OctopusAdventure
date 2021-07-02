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
        bool alive = true;      
        public void Run()
        {
            GameStart();
        }
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
                PlayerHealth = 0;
                Console.ReadKey();
            }

            else if (command == "eat")
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
                    "had you not left when you did surely youd be whale food by now! As you swim around you come across a cave. " +
                    "You decide since the open water was so dangerous this might be a welcome escape");
                Console.ReadKey();
                TunnelEnding();
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
                    "the whale was still submerged so you had to squeeze out and hurt yourself in the process. You get out of the whale and keep swimming on your way..." +
                    "As you swim around you come across a cave. You decide since the open water was so dangerous this might be a welcome escape");
                DamageTaken(35);
                Console.ReadKey();
                TunnelEnding();
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
                        "out. You both hit the sea floor pretty hard. As you get up you move around and come across a cave. You decide since the open water was so dangerous this might be a welcome escape");
                        DamageTaken(45);
                        Console.ReadKey();
                        TunnelEnding();
                        break;
                    case 2:
                        Console.WriteLine("\n\nYou waddle over to the pile of fish bites. As you come up to it you see something else is there! Its a crab! The " +
                        "crab doesnt notice you are there so you get close enough to eat some of the fish. The fish energizes you but the crab " +
                        "then notices you! The crab while angry with your " +
                        "interuption starts clawing all around to get you! One of the missed claw attempts hit the whales tongue and the whale subsequently spits both you and crab" +
                        "out. You both hit the sea floor pretty hard. You decide since the open water was so dangerous this might be a welcome escape");
                        HealHealth(20);
                        Console.ReadKey();
                        TunnelEnding();
                        break;
                    case 3:
                        Console.WriteLine("\n\nYou waddle over to the pile of fish bites. As you come up to it you see something else is there! Its a crab! The crab while angry with your " +
                        "interuption starts clawing all around to get you! One of the missed claw attempts hit the whales tongue and the whale subsequently spits both you and crab" +
                        "out. You both hit the sea floor pretty hard. You decide since the open water was so dangerous this might be a welcome escape");
                        DamageTaken(25);
                        Console.ReadKey();
                        TunnelEnding();
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
                    "swords stuck in the whales tongue. You adrenaline from conqouring this ordeal has healed you some! As you swim around you come across a cave. " +
                    "You decide since the open water was so dangerous this might be a welcome escape");
                HealHealth(15);
                Console.ReadKey();
                TunnelEnding();
            }
            else if (command == "poke")
            {
                Console.WriteLine("\n\nAfter opting to take a slightly less aggressive path you poke the whales tongue several times. The whale eventually gets annoyed" +
                    " enough to spit you out but it spits you into the sea floor and you hit to ground pretty hard! As you swim around you come across a cave. " +
                    "You decide since the open water was so dangerous this might be a welcome escape");
                DamageTaken(25);
                Console.ReadKey();
                TunnelEnding();
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
                TunnelEnding();
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
                    "You escape out of there as quick as you can and leave the reef for good! As you swim around you come across a cave. " +
                    "You decide since the open water was so dangerous this might be a welcome escape");
                Console.ReadKey();
                TunnelEnding();
            }
            else if (command == "swim")
            {
                Console.WriteLine("\n\nLeaving was the best option you could think of but the eels range on their shock is really far! You get stunned and the eels begin to " +
                    "attack you. Unfortunatley you cant move thanks to the shock and there was nothing else you can do at this point. Your death is inevitable...");
                PlayerHealth = 0;
                Console.ReadKey();
            }
            else
            {
                InvalidCommand();
                Coral2();
            }
        }
        public void TunnelEnding()
        {
            Console.Clear();
            Console.WriteLine("You emerge from the darkened tunnel to the light beaming in from the other end. \n" +
                "As the light begins to illuminate your surrounding area you see three destinct Caves directly in front of you.\n" +
                "To the left is a dimly lit cave, directly ahead is a slightly large cave opening, and to the right is a cave with barely enough space to crawl into. \n" +
                "What will it be?");
            Console.WriteLine("Please type your answer: (Hint: Left, center, or right)");

            string tunnelAnswer = Console.ReadLine().ToLower();

            if (tunnelAnswer == "left")
            {

                Console.WriteLine("You veer off to the left heading towards the dimly lit cavern.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                LeftCave();
            }

            if (tunnelAnswer == "center")
            {
                Console.Clear();
                Console.WriteLine("You head straight forward towards the largest of the three caves.\n" +
                    "You scurry inside the cave safely");
                Console.WriteLine("Wow this cave sure is large. The ceilings must be at least 20 feet.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                CenterCave();
            }
            if (tunnelAnswer == "right")
            {
                Console.Clear();
                Console.WriteLine("You run off to the right towards the smallest of the three caves.\n" +
                    "You squeeze your little Octopus body into the small cave enterance");
                Console.WriteLine("You squeeze through the opening until you find yourself firmly inside the cave with a path forward.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                RightCave();
            }
            else
            {
                TunnelEnding();
            }
        }
        public void OldRustyReef()
        {
            Console.Clear();

            Console.WriteLine("You swim over to the old rusty reef in the background. \n" +
                "Immediately upon entering the reef you sense that something just isn't right. You feel as if you are being watched. \n" +
                " You swim forward and immediately see something dart across the coral just past your view straight ahead.\n" +
                "You assess the situation and realize you have three solid options. You can run after what you saw directly ahead of you, you can just high tail it out of there, or just dive your ocotopus body behind a rock.\n" +
                "What would you like to do?");

            Console.WriteLine("Follow, Run, or Hide?");

            string reefAnswer = Console.ReadLine().ToLower();

            if (reefAnswer == "follow")
            {
                SeaHorseFight();
            }
            else if (reefAnswer == "run")
            {
                SeaHorseFight();
            }
            else if (reefAnswer == "hide")
            {
                SeaHorseFight();
            }
            else
            {
                OldRustyReef();
            }
        }
        public void SeaHorseFight()
        {
            Console.Clear();
            Console.WriteLine("You run forward chasing after the mysterious dashing object. You push forward past a coral opening. \n" +
                "As you hit the open water you realize you're almost face to face with a very large and very angry seahorse. \n" +
                "He is at least twice your size. You fear running might not be an option.");
            Console.WriteLine("Should you FIGHT the SeaHorse, or swim BACK to the previous area?");
            Console.WriteLine("FIGHT or BACK");
            string seaHFight = Console.ReadLine().ToLower();
            if (seaHFight == "fight")
            {
                Console.Clear();
                Console.WriteLine("You dash after the seahorse in the hopes of startling it and getting a surprise upper edge\n" +
                    "The seahorse is taken off guard and is whacked with your tentacle. Confused and scared the giant Seahorse flees");
                Console.WriteLine($"Health: {PlayerHealth}/100 ");
                Console.ReadKey();
                KrabRoom();
            }
            else if (seaHFight == "back")
            {
                Console.Clear();
                Console.WriteLine("You immediately turn around and try to run away. The freakishly large seahorse sees this weakness and snaps its tail landing a glancing blow as you narrowly escape");
                DamageTaken(30);
                KrabRoom();
            }
            else
            {
                SeaHorseFight();
            }
        }
        public void KrabRoom()
        {
            Console.Clear();
            Console.WriteLine("You enter the room with a giant crab on the door.\n" +
                "As you enter the door behind you slams shut.It is locked shut from this end. \n" +
                "You begin to hear steam noises begin to whistle around you. The noise appears to be getting closer\n" +
                "From the darkness on the opposite side of the room appears a monstrous creature.\n" +
                " 'It seems you have finally stumbled into my trap.' the giant Crab before you says before fully revealing itself. " +
                "I am going to give you one chance to make it out of here alive. You must answer 3 very specific trivia questions.\n" +
                "How many Amigos are there?");
            Console.WriteLine("Please type your answer: (Hint: Honestly not that many amigos)");

            string krabRiddle = Console.ReadLine().ToLower();

            if (krabRiddle == "3")
            {
                Console.Clear();
                Console.WriteLine("You hear the steam begin to swirl around you...\n" +
                    "\"That is correct. Question 1 of 3 answered\"");
                Console.WriteLine("The krab seems pleased with your random trivia skills and allows you to continue");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                KrabRoom2();
            }

            else
            {
                Console.Clear();
                Console.WriteLine("The darkness begins to surround you\n" +
                    "\"You seem to lack a very basic understanding of amigos trivia unfortunately\"");
                Console.WriteLine("The steam begins to fill the chamber. You are surrounded.\n" +
                    "You begin to feel a sharp pain in your lungs as you breathe in the toxic fumes");
                DamageTaken(20);
                Console.ReadKey();
                KrabRoom2();
            }
        }
        public void KrabRoom2()
        {
            Console.Clear();
            Console.WriteLine("One of the large misnomers of the sea is that sea creatures don't love 90's music.\n" +
                "In order to accumulate such impressive size I've had to spend so much time eating literally everything.\n" +
                "The only way I was able \n" +
                "How many solo albums did 2pac release during his life?");
            Console.WriteLine("Please type your answer: (Hint: Stop counting the 75 albums that came out after he died please)");

            string krabRiddle1 = Console.ReadLine().ToLower();

            if (krabRiddle1 == "4")
            {
                Console.Clear();
                Console.WriteLine("You hear the steam begin to swirl around you...\n" +
                    "\"That is correct. Question 2 of 3 answered\"");
                Console.WriteLine("The krab seems pleased with your random trivia skills and allows you to continue");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                KrabRoom3();
            }

            else
            {
                Console.Clear();
                Console.WriteLine("The darkness begins to surround you\n" +
                    "\"You seem to lack a very basic understanding of 2pac trivia unfortunately\"");
                Console.WriteLine("The steam begins to fill the chamber. You are surrounded.\n" +
                    "You begin to feel a sharp pain in your lungs as you breathe in the toxic fumes");
                DamageTaken(20);
                Console.ReadKey();
                KrabRoom3();
            }
        }
        public void KrabRoom3()
        {
            Console.Clear();
            Console.WriteLine("You have reached the third and final trivia question. Your freedom awaits.\n" +
                "With all this freetime us Aquatic creatures often yearn for more entertainment.\n" +
                "Specifically late 90's era professional wrestling. We hope you came prepared.\n" +
                "How many times was Booker T a WCW World Heavyweight Champion?");
            Console.WriteLine("Please type your answer: (Hint:More then 2 less than 6 )");

            string krabRiddle2 = Console.ReadLine().ToLower();

            if (krabRiddle2 == "5")
            {
                Console.Clear();
                Console.WriteLine("You hear the steam begin to swirl around you...\n" +
                    "\"That is correct. All Questions answered. You are free to go. Long live Booker T...\"");
                Console.WriteLine("The krab seems pleased with your random trivia skills and allows you to continue");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                TigerShark();
            }

            else
            {
                Console.Clear();
                Console.WriteLine("The darkness begins to surround you\n" +
                    "\"You seem to lack a very basic understanding of wrestling trivia unfortunately\"");
                Console.WriteLine("The steam begins to fill the chamber. You are surrounded.\n" +
                    "You begin to feel a sharp pain in your lungs as you breathe in the toxic fumes");
                DamageTaken(20);
                Console.ReadKey();
                TigerShark();            }
        }
        public void TigerShark()
        {
            Console.Clear();
            Console.WriteLine("You emerge pass the room with the giant crab in it and find yourself in an open reef.\n" +
                "There are a few coral around and ocean life seems to be moving but something just feels out of place.\n" +
                "Out of the corner of your left eye you see it. A giant 300 foot Tiger Shark. \n" +
                "The choice is simple. And it is yours to make. Run or Fight");
            Console.WriteLine("Please type your answer: (Hint: Its a really big shark imma be honest)");

            string tigerSharkFight = Console.ReadLine().ToLower();

            if (tigerSharkFight == "run")
            {
                Console.Clear();
                Console.WriteLine("You begin to run sprint away from the tiger.\n" +
                    "The tiger shark never even looked at you. Got away safely");
                Console.WriteLine("You had a run in with a tiger shark and got to tell the tale. Lucky.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                KrabRoom3();
            }

            else
            {
                Console.Clear();
                Console.WriteLine("You make a mad dash at the tail of the tiger shark.\n" +
                    "Right before you near the shark it snaps around and that's all she wrote");
                Console.WriteLine("You are chomped up in a single bite.\n" +
                    "Please stop fighting things that big without some help.");
                DamageTaken(100);
                Console.ReadKey();
                KrabRoom3();
            }
        }
        public void LeftCave()
        {
            Console.Clear();
            Console.WriteLine("You squint your eyes in an attempt to see in the darkness. \n" +
                "There is still almost no visibility. You know you're not the only thing in the room.\n" +
                "Something quickly swims across the room making a distinct and fast noise.\n" +
                "Should you follow the noise or stay put?");
            Console.WriteLine("Please type your answer: (Hint: FOLLOW or Stay)");

            string leftCaveAnswer = Console.ReadLine().ToLower();

            if (leftCaveAnswer == "follow")
            {
                Console.Clear();
                Console.WriteLine("You begin to swim after the noise as it begins to dart again.\n" +
                    "You race after the noise even faster this time and can sense whatever it is must be close");
                Console.WriteLine("Gotcha.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                OldRustyReef();
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Instead of just blindly following the random noise you choose to stay put.\n" +
                    "You sense the noise swimming off in the distance and before long it is out of earshot.");
                Console.WriteLine("You swim forward in the now empty dimly lit cave until you reach an exit.\n" +
                    "Alongside the exit you pick up a tasty little snack as you exit");
                DamageTaken(35);
                Console.ReadKey();
                SnailTrail();
            }
        }
        public void CenterCave()
        {
            Console.Clear();
            Console.WriteLine("You swim forward and enter the largest of the three caves.\n" +
                "There is enough space in this cave for you an Octopus and an entire Chevy Movie Theater. If that helps understand the sheer size.\n" +
                "However just as you would expect the giant huge mega cave is mostly empty. There is a tiny little hole in the back.\n" +
                "Will you crawl through or run back?");
            Console.WriteLine("Please type your answer: (Hint: Crawl or Leave)");

            string centerCaveAnswer = Console.ReadLine().ToLower();

            if (centerCaveAnswer == "crawl")
            {
                Console.Clear();
                Console.WriteLine("You find a nifty little exit.\n" +
                    "Wow this big empty cave sure was easy to traverse");
                Console.WriteLine("Wow! So close to the end!");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                SnailTrail();
            }

            else
            {
                Console.Clear();
                Console.WriteLine("You begin to turn around and skidaddle out of there.\n" +
                    "Thats really a fun word isn't it?");
                Console.WriteLine("You return to the cave selection portion of this fun little excersion\n" +
                    "Very excited for you.");
                Console.ReadKey();
                TunnelEnding();
            }
        }
        public void RightCave()
        {
            Console.Clear();
            Console.WriteLine("You swim forward and enter the largest of the three caves.\n" +
                "There is enough space in this cave for you an Octopus and an entire Chevy Movie Theater. If that helps understand the sheer size.\n" +
                "However just as you would expect the giant huge mega cave is mostly empty. There is a tiny little hole in the back.\n" +
                "Will you crawl through or run back?");
            Console.WriteLine("Please type your answer: (Hint: Crawl or Leave)");

            string centerCaveAnswer = Console.ReadLine().ToLower();

            if (centerCaveAnswer == "crawl")
            {
                Console.Clear();
                Console.WriteLine("You find a nifty little exit.\n" +
                    "Wow this big empty cave sure was easy to traverse");
                Console.WriteLine("Wow! So close to the end!");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                SnailTrail();
            }

            else
            {
                Console.Clear();
                Console.WriteLine("You begin to turn around and skidaddle out of there.\n" +
                    "Thats really a fun word isn't it?");
                Console.WriteLine("You return to the cave selection portion of this fun little excersion\n" +
                    "Very excited for you.");
                Console.ReadKey();
                TunnelEnding();
            }
        }
        public void SnailTrail()
        {
            Console.Clear();
            Console.WriteLine("You enter a dark and dingy cavern with two distinct slime trails on the floor. \n" +
                "The slime trails are thick and protruding from the ground. ");
            Console.WriteLine("The two trails run to opposite ends of the room. \n" +
                "What will it be? Will you go left or right?");
            string snailAnswer = Console.ReadLine().ToLower();
            if (snailAnswer == "left")
            {
                Console.WriteLine("You follow the left  snail trail");
                Console.WriteLine("You eventually reach a room where the trail ends abruptly.\n" +
                    "The snail appears to have back tracked and is not here. You should be free to exit through the back of the room");
                Console.ReadKey();
                SnailExit();
            }
            else if (snailAnswer == "right")
            {
                Console.WriteLine("You follow the right snail path and it leads you to the room to the right. " +
                    "You are now face to face with a snail roughly your size. He appears to be friendly");
                HealHealth(100);
                Console.ReadKey();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                SnailExit();
            }
            else
            {
                Console.WriteLine("You need to make a decision.\n" +
                    "You can't run from snails forever.");
                SnailTrail();
            }
        }
        public void SnailExit()
        {
            Console.Clear();
            Console.WriteLine("You are nearing the exit. The only thing standing between you and home is one last question. \n" +
                "For some reason seacreatures designers are really heavy on the trivia. As a result in order to pass the final little barrier you will have to answer a final question correctly. ");
            Console.WriteLine("Rey Mysterio grew up in what three digit area code?  \n" +
                "What will it be? Hint:1,6,9 are used");
            string snailAnswer = Console.ReadLine().ToLower();
            if (snailAnswer == "619")
            {
                GotHome();
            }
            else
            {
                Console.WriteLine("You need to make a decision.\n" +
                    "You can't run from the end forever");
                SnailTrail();
            }
        }
        public void GotHome()
        {
            Console.Clear();
            Console.WriteLine("Who knew geographically based wrestling knowledge would be so practically useful.");
            Console.WriteLine("You're a hero. A champion. Wow. The best. \n" +
            "I've never been so proud of someone in my entire life. And you're not even a someone. Just an Octopus. ");
            Console.ReadKey();
            Environment.Exit(0);
        }
        public int DamageTaken(int damage)
        {
            PlayerHealth = PlayerHealth - damage;
            Console.WriteLine($"\n\nYou took {damage} damage!");
            Console.WriteLine($"Health: {PlayerHealth}/100");
            if (PlayerHealth <= 0)
            {
                Console.Clear();
                Console.WriteLine("You close your eyes for the last time.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            return PlayerHealth;
        }
        public int HealHealth(int heal)
        {
            ProgramUI newHealth = new ProgramUI();
            PlayerHealth = PlayerHealth + heal;
            Console.WriteLine($"\n\nYou were healed by {heal}!");
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
            int poisonDamage = poison.Next(1, damage) + 10;
            PlayerHealth = PlayerHealth - poisonDamage;
            Console.WriteLine($"\n\nYou took {poisonDamage} poison damage and will be poisoned next map!");
            Console.WriteLine($"Health: {PlayerHealth}/100");
            return PlayerHealth;
        }
        public int Poison2(int damage)
        {
            Random poison = new Random();
            int poisonDamage = poison.Next(0, damage) - 10;
            PlayerHealth = PlayerHealth - poisonDamage;
            Console.WriteLine($"\n\nYou took {poisonDamage} residual poison damage!");
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

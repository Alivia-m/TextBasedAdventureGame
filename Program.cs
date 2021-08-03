using System;
using System.Threading;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You've just arrived home late from another long day of work at a job you hate");
            Console.WriteLine("");
            Console.WriteLine("The only thing on your mind right now is trying to get as much sleep as possible so you can get up and do it all over again tomorrow...");
            Thread.Sleep(4000);
            Console.WriteLine("");
            Console.WriteLine("You sigh deeply as you look around your dimly lit kitchen. The clock on your microwave reading 12:45 am");
            Thread.Sleep(4000);
            Console.WriteLine("");
            Console.WriteLine("You notice that your roommate has forgotten to take the trash out. Again.");
            Thread.Sleep(4000);
            Console.WriteLine("");
            Console.WriteLine("'Should i just do it myself?' You wonder out loud");
            Console.WriteLine("");
            Console.WriteLine("Take out the trash: Yes/No?");

            var input = Console.ReadLine().ToLower();
            Console.Clear();
           if(input == "yes")
            {
                Console.WriteLine("You begrudgingly grab the trashbag and head out the door");
                Console.WriteLine("");
                Thread.Sleep(2000);
                Console.WriteLine("As you head reach the dumpsters at the end of your driveway you suddenly feel as though you're being watched");
                Console.WriteLine("You turn to notice a grey cat sitting on your neighbors mailbox watching you closely, its yellow eyes seem to glow in the dim light. One you've never seen in the neighborhood before");
                Console.WriteLine("");
                Thread.Sleep(2000);
                Console.WriteLine("...");
                Console.WriteLine("'Thats not creepy at all' you mutter under your breath as you head back into the house");
            }
           if(input == "no")
            {
                Console.WriteLine("'Forget it. They can do it in the morning'");
            }

            Console.WriteLine("");
            Console.WriteLine("You head on to bed hoping the morning doesn't come too soon");
            Thread.Sleep(8000);
            Console.Clear();


            Thread.Sleep(2000);
            Console.WriteLine("???: Hello?");
            Thread.Sleep(1000);
            Console.WriteLine("???: Are you alright?");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("'What in the world...'");
            Thread.Sleep(2000);
            Console.WriteLine("");
            Console.WriteLine("Bewildered, you open your eyes to see an odd figure staring down at you");
            Console.WriteLine("A man of unknown age, with a grey hair and strange yellow eyes ");
            Thread.Sleep(3000);

            Console.WriteLine("");
            Console.WriteLine("???: Oh! You're alive, how wonderful!");
            Console.WriteLine("Then what an odd place you chose to fall asleep in");
            Thread.Sleep(2000);

            Console.WriteLine("");
            Console.WriteLine("You take a quick look at your surroundings. A beautiful meadow of lavender flowers");
            Console.WriteLine("'How nice' you think briefly");
            Console.WriteLine("");
            Thread.Sleep(2000);

            Console.WriteLine("Suddenly realizing you have more pressing concerns than admiring the scenery, you turn to look at the strange man grinning at you");
            Console.WriteLine("");

            bool stillRunning = true;
            while(stillRunning)
            {
                Console.WriteLine("Do you:");
                Console.WriteLine("A. Run for it");
                Console.WriteLine("B. Question him");

                var response = Console.ReadLine().ToLower();

                switch (response)
                {
                    case "a":
                        Console.WriteLine("You jump to your feet, making a run for it in the opposite direction, the strange mans laughter echoing in your ears");
                        Console.Write("");
                        Thread.Sleep(500);
                        Console.WriteLine("???: Whats the rush?");
                        Console.WriteLine("");
                        Console.WriteLine("You ignore his taunts and carry on, trying to figure out where you are");
                        Console.WriteLine("You're so distracted that you don't notice the cliff straight ahead and run right off of it");
                        Thread.Sleep(9000);
                        Console.Clear();

                        Console.WriteLine("Suddenly you're back in your room staring at the ceiling, your heart pounding loudly in your chest");
                        Console.WriteLine("'Well that was a... interesting dream' you think to yourself as you try to catch your breath");
                        Console.WriteLine("'It was a dream right?' everything felt so real... to real");
                        Thread.Sleep(2000);
                        Console.WriteLine("");
                        Console.WriteLine("Shaking your head you push the thought out of your mind");
                        Console.WriteLine("'I'm too tired for this' you mutter and settle down to go back to sleep...");
                        Thread.Sleep(3000);
                        Console.WriteLine("Not noticing a strange cat watching you from the branches of the tree outside your window");
                        Environment.Exit(0);
                        stillRunning = false;
                        break;
                    case "b":
                        Console.WriteLine("'Who are you?' you shout trying to sound as intimidating as you can");
                        Console.WriteLine("");
                        Thread.Sleep(1000);
                        Console.WriteLine("The stranger grinned at my request, his teeth unsually sharp");
                        Console.WriteLine("???: Well, not that it's important, but the others call me Halloween");
                        Console.WriteLine("");
                        Thread.Sleep(1000);
                        Console.WriteLine("'Halloween?' I repeated in disbelief 'What kind of name is that?'");
                        Console.WriteLine("'And who are these others?'");
                        Console.WriteLine("");
                        stillRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid response");
                        break;
                }

                Thread.Sleep(2000);
                Console.WriteLine("Halloween: Not important. What matters is why you're here. Do you even know where you are?");
                Console.WriteLine("");
                Thread.Sleep(1000);

                Console.WriteLine("Wait... where am I?");
                Console.WriteLine("The last thing I remember was falling asleep in my room, not a meadow");
                Console.WriteLine("");
                Thread.Sleep(4000);

                Console.WriteLine("Halloween sighed in exasperation as if he could hear what i was thinking");
                Console.WriteLine("");
                Console.WriteLine("Halloween: Wonderful, they must've assigned me to the wrong human again");
                Console.WriteLine("");
                Thread.Sleep(3000);
                Console.WriteLine("The wrong human?");
                Console.WriteLine("");
                Console.WriteLine("Halloween turned his back to me, and suddenly started shouting at the sky");
                Console.WriteLine("");
                Console.WriteLine("Halloween: This is the 3rd time this month! I'm expecting an end of the year bonus for this you know!");
                Console.WriteLine("He turned back to me with an annoyed expression");

                Thread.Sleep(3000);
                Console.WriteLine("");
                Console.WriteLine("Halloween: Well? What are you waiting for? Hurry up and leave!");
                Console.WriteLine("");

                Console.WriteLine("'Well... I'm not sure how to' I said awkwardly");
                Thread.Sleep(1000);
                Console.WriteLine("");
                Console.WriteLine("'Amateurs...' he muttered as he snapped his fingers");
                Console.WriteLine("I yelled in shock as The meadow around us suddenly began to disappear. Pieces of where reality should've been rapidly being replaced by darkness ");
                Console.WriteLine("");
                Console.WriteLine("'When you wake up' he shouted from across the meadow 'Try to think of this as nothing but a bad dream!'");
                Console.WriteLine("Now more confused than ever I tried to ask what he meant, only for the ground beneath me to disappear as well...");
                Thread.Sleep(8000);

                Console.WriteLine("Suddenly you're back in your room staring at the ceiling, your heart pounding loudly in your chest");
                Console.WriteLine("'Well that was a... interesting dream' you think to yourself as you try to catch your breath");
                Console.WriteLine("'It was a dream right?' everything felt so real... to real");
                Thread.Sleep(2000);
                Console.WriteLine("");
                Console.WriteLine("Shaking your head you push the thought out of your mind");
                Console.WriteLine("'I'm too tired for this' you mutter and settle down to go back to sleep...");
                
                Environment.Exit(0);



            } 
        }
    }
}

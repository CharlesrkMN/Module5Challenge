using System;
using System.Formats.Asn1;

namespace DadJokeGen
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare and initiate array of dad jokes
            string[] dadJokes = ["What does a baby computer call his father? Data.",
            "Which days are the strongest? Saturday and Sunday. The rest are weekdays.",
            "How do cows stay up to date? They read the Moo-spaper.",
            "I hate my job—all I do is crush cans all day. It's soda pressing.",
            "What do you call a beehive without an exit? Unbee-lievable.",
            "It's easy to convince ladies not to eat Tide Pods, but harder to deter gents.",
            "I found a wooden shoe in my toilet today. It was clogged.",
            "I don't trust stairs. They're always up to something.",
            "I used to hate facial hair, but then it grew on me.",
            "What's blue and not very heavy? Light blue.",
            "I don't get why bakers aren't wealthier. They make so much dough.",
            "How do you make a tissue dance? You put a little boogie in it."];

            //welcome user and ask if theyd like to hear some dad jokes
            Console.WriteLine("Welcome to the Dad joke generator!");
            Console.WriteLine("Would you like to see some jokes? (Yes/No): ");
            
            //read user answer
            string answer = Console.ReadLine();

            //loop while user wants to hear dad jokes
            while (answer == "Yes")
            {
                //generate a random number 0-11
                Random rnd = new Random();
                int joke  = rnd.Next(0, 11); 
                //display first dad joke
                Console.WriteLine(dadJokes[joke]);

                //generate a new random number 0-11
                joke = rnd.Next(0, 11);
                //display a second dad joke
                Console.WriteLine(dadJokes[joke]);

                //ask user if theyd like more jokes
                Console.WriteLine("Would you like to see more? (Yes/No)");
                string again = Console.ReadLine();

                //if user enters no
                if (again == "No")
                {
                    Console.WriteLine("Hope you enjoyed and thanks for playing!"); //thank the user and exit
                    break;
                }

                //if user doesnt enter no: continue looping
                else
                {
                    continue;
                }
            }

        }
    }
}
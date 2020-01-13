using System;

namespace CommandLineBlackjack
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Menu();
            Console.ReadLine();
        }

        static void Menu()
        {
            Console.WriteLine("Welcome to Blackjack!");
            Console.WriteLine("Are you ready to play?");
            Console.Write("Y for Yes, N for No: ");
            string isYes = Console.ReadLine();
            if (isYes == "y" || isYes == "Y")
            {

                Console.WriteLine("");
                Play();

            }
            else if (isYes == "n" || isYes == "N")
            {
                Console.Write(" Would You like to quit? ");
                string quit = Console.ReadLine();
                if (quit == "y" || quit == "Y")
                {
                    Console.WriteLine("GoodBye");

                }
                else
                {
                    Console.WriteLine("");
                    Menu();
                }
            }
            else
            {
                Console.WriteLine(" Error");
            }
        }
        static void Play()
        {
            Console.WriteLine("Let's Play");
            dealPlayer();
            dealDealer();

        }

        static void dealPlayer()
        {
            int card1;
            int card2;

            Console.WriteLine("Dealing...");

            Random random1 = new Random();
            card1 = random1.Next(1, 13);
            Random random2 = new Random();
            card2 = random2.Next(1, 13);

            if (card1 == 1)
            {
                Console.WriteLine("You got an ace. Your other card is a " + card2);
                Console.Write("Ace = 1 or 11? ");
                int card1Ace = Convert.ToInt16(Console.ReadLine());
            }else if (card2 == 1)
            {
                Console.WriteLine("You got an ace. Your other card is a " + card1);
                Console.Write("Ace = 1 or 11? ");
                int card2Ace = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Hand: " + card1 + ", " + card2 + " (" + (card1 + card2) + ")");
            Console.Write("\nWould you like to hit (h) or stand (s): ");
            string play = Console.ReadLine();

            if (play == "h" || play == "H")
            {
                Console.WriteLine("Hit");
                cardShuffle();
            }
            else if (play == "s" || play == "S")
            {
                Console.WriteLine("Stand");
            }else
            {
                Console.WriteLine("No input selected, Redrawing...");
                dealPlayer();
            }

        }

        static void dealDealer()
        {

        }

        static int cardShuffle()
        {
            int randomCard;

            Random random = new Random();
            randomCard = random.Next(1, 14);

            return randomCard;
        }


    }
}

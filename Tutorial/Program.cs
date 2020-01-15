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
            int[] card = new int[6];

            Console.WriteLine("Dealing...");
            //Two new random cards assigned to card1, card2
            card[0] = cardShuffleP();
            card[1] = cardShuffleP();

            //If card drawn is ace player has choice to use it as 1 or 11
            if (card[0] == 1)
            {
                Console.WriteLine("You got an ace. Your other card is a " + card[1]);
                Console.Write("Ace = 1 or 11? ");
                card[0] = int.Parse(Console.ReadLine());
            }else if (card[1] == 1)
            {
                Console.WriteLine("You got an ace. Your other card is a " + card[0]);
                Console.Write("Ace = 1 or 11? ");
                card[1] = int.Parse(Console.ReadLine());
            }

            //this displays the player's current hand
            Console.WriteLine("Hand: " + card[0] + ", " + card[1] + " (" + (card[0] + card[1]) + ")");

            //draw1
            Console.Write("\nWould you like to hit (h) or stand (s): ");
            string play = Console.ReadLine();
            if (play == "h" || play == "H")
            {
                //player chose hit, a new random card is drawn and assisgned
                Console.WriteLine("Hit");
                card[2] = cardShuffleP();
                //new card is read to player
                Console.WriteLine("Hand: " + card[0] + ", " + card[1] + ", " + card[2] + " (" + (card[0] + card[1] + card[2]) + ")");
            }
            else if (play == "s" || play == "S")
            {
                Console.WriteLine("Stand");
                playerStand();
            }else
            {
                Console.WriteLine("No input selected, Redrawing...");
                dealPlayer();
            }

            //draw2
            Console.Write("\nWould you like to hit (h) or stand (s): ");
            string play2 = Console.ReadLine();
            if (play2 == "h" || play2 == "H")
            {
                //player chose hit, a new random card is drawn and assisgned
                Console.WriteLine("Hit");
                card[3] = cardShuffleP();
                //new card is read to player
                Console.WriteLine("Hand: " + card[0] + ", " + card[1] + ", " + card[2] + ", " + card[3] + " (" + (card[0] + card[1] + card[2] + card[3]) + ")");
            }
            else if (play2 == "s" || play2 == "S")
            {
                Console.WriteLine("Stand");
                playerStand();
            }
            else
            {
                Console.WriteLine("No input selected, Redrawing...");
                dealPlayer();
            }

            //draw3
            Console.Write("\nWould you like to hit (h) or stand (s): ");
            string play3 = Console.ReadLine();
            if (play3 == "h" || play3 == "H")
            {
                //player chose hit, a new random card is drawn and assisgned
                Console.WriteLine("Hit");
                card[4] = cardShuffleP();
                //new card is read to player
                Console.WriteLine("Hand: " + card[0] + ", " + card[1] + ", " + card[2] + ", " + card[3] + ", " + card[4] + " (" + (card[0] + card[1] + card[2] + card[3]) + card[4] + ")");
            }
            else if (play3 == "s" || play3 == "S")
            {
                Console.WriteLine("Stand");
                playerStand();
            }
            else
            {
                Console.WriteLine("No input selected, Redrawing...");
                dealPlayer();
            }

            //draw4
            Console.Write("\nWould you like to hit (h) or stand (s): ");
            string play4 = Console.ReadLine();
            if (play4 == "h" || play4 == "H")
            {
                //player chose hit, a new random card is drawn and assisgned
                Console.WriteLine("Hit");
                card[5] = cardShuffleP();
                //new card is read to player
                Console.WriteLine("Hand: " + card[0] + ", " + card[1] + ", " + card[2] + ", " + card[3] + ", " + card[4] + ", " + card[5] + " (" + (card[0] + card[1] + card[2] + card[3]) + card[4] + card[5] +")");
            }
            else if (play4 == "s" || play4 == "S")
            {
                Console.WriteLine("Stand");
                playerStand();
            }
            else
            {
                Console.WriteLine("No input selected, Redrawing...");
                dealPlayer();
            }


        }

        static void dealDealer()
        {
            
            int[] cards = new int[10];

            //Dealer Draw 2 new cards
            cards[0] = cardShuffleD();
            cards[1] = cardShuffleD();

            //Dealer ace choice
            if (cards[0] == 1)
            {
                if (11 + cards[1] >= 21)
                {
                    cards[0] = 1;
                }
                else
                {
                    cards[0] = 11;
                }
            }
            else if (cards[1] == 1)
            {
                if (11 + cards[0] >= 21)
                {
                    cards[1] = 1;
                }
                else
                {
                    cards[1] = 11;
                }
            }
            Console.WriteLine();
            if (cards[0] + cards[1] <= 19)
            {
                //dealer hit
                //draw1
                Console.WriteLine("Hit");
                cards[2] = cardShuffleP();

            }
            else if (cards[0] + cards[1] >= 21)
            {
                //Dealer Bust
                Console.WriteLine("Dealer Bust \nYou Win!");

            }else if (cards[0] + cards[1] > 19 && cards[0] + cards[1] < 21)
            {
                Console.WriteLine("Dealer Stands");
                //Dealer Stand
            }

            Console.WriteLine();
            if (cards[0] + cards[1] + cards[2] <= 19)
            {
                //dealer hit
                //draw1
                Console.WriteLine("Hit");
                cards[3] = cardShuffleP();
                if (cards[0] + cards[1] + cards[2] + cards[3] > 21)
                {
                    Console.WriteLine("\nDealer Bust!\nPlayer Wins!");
                    Play();
                }
            }
            else if (cards[0] + cards[1] + cards[2] >= 21)
            {
                //Dealer Bust
                Console.WriteLine("Dealer Bust \nYou Win!");

            }
            else if (cards[0] + cards[1] + cards[2] > 19 && cards[0] + cards[1] + cards[2] < 21)
            {
                Console.WriteLine("Dealer Stands");
                //Dealer Stand
            }
        }
        static void playerStand()
        {

        }

        static int cardShuffleD()
        {
            int newDealerCard;

            Random random = new Random();
            newDealerCard = random.Next(1, 13);

            return newDealerCard;
        }

        static int cardShuffleP()
        {
            int newPlayerCard;

            Random random = new Random();
            newPlayerCard = random.Next(1, 13);

            return newPlayerCard;
        }

    }
}

using System;

namespace U04091701
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cards = new string[52];
            Random r = new Random();
            int k = 0;
            bool[] choice = new bool[52];
            bool done = false;
            int c = 0;
            bool moreCard = true;
            int poäng = 0;
            int score = 0;


            for (int i = 0; i < 52; i++)
            {
                choice[i] = true;
            }
            for (int i = 0; i < 13; i++)
            {
                cards[i] = "Heart " + (i + 1);
            }
            for (int i = 13; i < 26; i++)
            {
                cards[i] = "Spades " + (i - 12);
            }
            for (int i = 26; i < 39; i++)
            {
                cards[i] = "Daimond " + (i - 25);
            }
            for (int i = 39; i < 52; i++)
            {
                cards[i] = "Spade " + (i - 38);
            }
            while (moreCard)
            {
                done = false;
                Console.WriteLine("Do you want to draw a card? ");
                string pick = Console.ReadLine();
                if (pick == "yes" || pick == "Yes" || pick == "YES")
                {
                    moreCard = true;
                }
                if (pick == "no" || pick == "No" || pick == "NO")
                {
                    moreCard = false;
                }


                if (moreCard)
                {
                    while (!done)
                    {
                        k = r.Next(0, 52);
                        if (choice[k])
                        {
                            Console.Write("You drew " + cards[k]);
                            choice[k] = false;
                            c++;
                            string[] cardsDrawn = cards[k].Split(' ');
                            poäng = Convert.ToInt32(cardsDrawn[1]);
                            score += poäng;
                            if (score > 21)
                            {
                                Console.WriteLine(", you lost! You got more than 21...");
                                done = true;
                                moreCard = false;
                            }
                            else if (score == 21)
                            {
                                Console.WriteLine(". Congratz you got 21 and won!!");
                                Console.ReadLine();
                                return;
                            }
                            else
                            {
                                Console.WriteLine(" your score are " + score);
                                done = true;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Your score are " + score);
                }
            }

        }
    }
}


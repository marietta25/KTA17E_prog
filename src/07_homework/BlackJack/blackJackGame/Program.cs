using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace blackJackGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // vajalik mingi kogum kaardipakist - 52 segatud kaarti, mille igat elementi saab vaid 1 korra valida

            List<string> cards = new List<string> {"2H","3H","4H","5H","6H","7H","8H","9H","10H","JH","QH","KH","AH",
                "2D","3D","4D","5D","6D","7D","8D","9D","10D","JD","QD","KD","AD",
                "2C","3C","4C","5C","6C","7C","8C","9C","10C","JC","QC","KC","AC",
                "2S","3S","4S","5S","6S","7S","8S","9S","10S","JS","QS","KS","AS"};

            var shuffledDeck = cards.OrderBy(a => Guid.NewGuid()).ToList();

            List<string> player = new List<string>();
            List<string> house = new List<string>();

            int PlayerTotal = 0;
            int HouseTotal = 0;

            Console.WriteLine("Welcome to the game of Blackjack!");
            Console.WriteLine();

            // mängijale jagatakse 2 kaarti (nähtavad)
            // diiler saab 2 kaarti- 1 näha, 1 mitte
            player = FirstRoundPlayer(shuffledDeck[0], shuffledDeck[1], player);
            shuffledDeck.RemoveAt(0);
            shuffledDeck.RemoveAt(0);

            house = FirstRoundHouse(shuffledDeck[0], shuffledDeck[1], house);
            shuffledDeck.RemoveAt(0);
            shuffledDeck.RemoveAt(0);

            PlayerTotal = CalcTotal(player, PlayerTotal);
            HouseTotal = CalcTotal(house, HouseTotal);

            // * esimene round - kui käes on pildikaart ja äss, on see mängija võitnud - 'natural' e blackjack
            bool natural = NaturalCheck(player, house);
            bool hitPlayer = true;
            bool hitHouse = true;
            if (natural)
            {
                FinishGame(PlayerTotal, HouseTotal);
                hitPlayer = false;
                hitHouse = false;
            }

            // mängija saab valida: kas võtab veel 1 kaardi või lõpetab
            while (hitPlayer)
            {
                AskPlayer();
                string choice = Console.ReadLine();
                // kui jätkab, jagatakse mängijale korraga 1 kaart
                // arvuti peab igal jagamisel käesolevad kaardid liitma: numbrikaardid (2-10), pildid (10), äss (1 või 11)
                // kui summa ületab 21, on mängija 'bust', lõhki läinud
                if (choice == "1")
                {
                    DealPlayer(shuffledDeck[0], player);
                    shuffledDeck.RemoveAt(0);
                    PlayerTotal = CalcTotal(player, PlayerTotal);
                    
                    if (PlayerTotal > 21)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You've gone bust!");
                        hitPlayer = false;
                    }
                }
                //mängija ei taha rohkem kaarte
                else if (choice == "2")
                {
                    PlayerTotal = CalcTotal(player, PlayerTotal);
                    Console.WriteLine();
                    Console.WriteLine($"You decided to stand on {PlayerTotal}");
                    hitPlayer = false;
                }
            }

            // kui diileri käes olev summa on väiksem kui 17, peab ta kaartide võtmist niikaua jätkama, kuni 17 või rohkem
            // kui diileri käes olev äss toob 11-na lugedes summaks 17-21, peab ässa lugema 11-na
            while ((HouseTotal < 17) && (hitHouse))
            {
                DealHouse(shuffledDeck[0], house);
                shuffledDeck.RemoveAt(0);
                HouseTotal = CalcTotal(house, HouseTotal);
            }

            if (HouseTotal >= 17 && HouseTotal < 22 && hitHouse)
            {
                Console.WriteLine();
                Console.WriteLine("House must stand");
            }
            if (HouseTotal > 21)
            {
                Console.WriteLine();
                Console.WriteLine("House has gone bust!");
            }

            //punktid loetakse kokku
            if (hitPlayer || hitHouse)
            {
                FinishGame(PlayerTotal, HouseTotal);
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
        static void AskPlayer()
        {
            // mängija saab valida: kas võtab veel 1 kaardi või lõpetab
            Console.WriteLine();
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Choose: 1 - Take another card");
            Console.WriteLine("Choose: 2 - Stand");
            Console.Write("I choose: ");
        }
        static List<string> DealPlayer(string card, List<string> player)
        {
            //deal top card to player
            Console.WriteLine($"You have been dealt {card}");
            player.Add(card);
            return player;
        }
        static List<string> DealHouse(string card, List<string> house)
        {
            //deal top card to house
            Console.WriteLine("House has been dealt [?]");
            house.Add(card);
            return house;
        }
        static List<string> FirstRoundPlayer(string card, string card2, List<string> cards)
        {
            //deal first 2 cards to player
            Console.WriteLine($"You have been dealt {card} and {card2}");
            cards.Add(card);
            cards.Add(card2);
            return cards;
        }
        static List<string> FirstRoundHouse(string card, string card2, List<string> cards)
        {
            //deal first 2 cards to house
            Console.WriteLine($"House has been dealt {card} and [?]");
            cards.Add(card);
            cards.Add(card2);
            return cards;
        }
        static bool NaturalCheck(List<string> cards1, List<string> cards2)
        {
            bool acePlayer = false;
            bool picturePlayer = false;
            bool aceHouse = false;
            bool pictureHouse = false;
            bool natural = false;
            foreach (var item in cards1)
            {
                if (item.Contains("A"))
                {
                    acePlayer = true;
                }
                if (item.Contains("J") || item.Contains("Q") || item.Contains("K"))
                {
                    picturePlayer = true;
                }
            }
            foreach (var item in cards2)
            {
                if (item.Contains("A"))
                {
                    aceHouse = true;
                }
                if (item.Contains("J") || item.Contains("Q") || item.Contains("K"))
                {
                    pictureHouse = true;
                }
            }
            if (acePlayer && picturePlayer)
            {
                Console.WriteLine();
                Console.WriteLine("You have got natural!");
                natural = true;
            }
            if (aceHouse && pictureHouse)
            {
                Console.WriteLine();
                Console.WriteLine("House has got natural!");
                natural = true;
            }
            return natural;
        }
        static int CalcTotal(List<string> cards, int total)
        {
            total = 0;
            foreach (var item in cards)
            {
                if (item.Contains("J") || item.Contains("Q") || item.Contains("K") || item.Contains("10"))
                {
                    total += 10;
                }
                else if (item.Contains("A"))
                {
                    //ässa väärtus sõltub, kes mängib ja mis kaartide summa kokku tuleb
                    total += 11;
                }
                else
                {
                    string result = Regex.Match(item, @"\d+").Value;
                    int resultValue = Int32.Parse(result);
                    total += resultValue;
                }
                //Console.WriteLine($"You have: {item}");
            }
            //Console.WriteLine($"Your total: {total}");
            return total;
        }
        static void FinishGame(int total1, int total2)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {total1} points vs House {total2} points");

            if (total1 == 21 && total2 != 21)
                Console.WriteLine("You have blackjack! You win!");
            else if (total1 < 22 && total2 < 22 && total1 > total2)
                Console.WriteLine("You win!");
            else if (total1 < 22 && total2 > 21 && total1 < total2)
                Console.WriteLine("You win!");
            else if (total2 == 21 && total1 != 21)
                Console.WriteLine("House has blackjack! House wins!");
            else if (total2 < 22 && total1 < 22 && total1 < total2)
                Console.WriteLine("House wins!");
            else if (total2 < 22 && total1 > 21 && total2 < total1)
                Console.WriteLine("House wins!");
            else if (total1 == total2)
                Console.WriteLine("It's a tie!");
            else if (total1 > 21 && total2 > 21)
                Console.WriteLine("Both players have gone bust!");
        }
    }
}

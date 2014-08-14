using System;
class DeckOfCards
    {
    static void Main(string[] args)
    {
            Console.WriteLine("Please pick a card! (Enter a number from 1 to 52!)");
            int cardChoice = int.Parse(Console.ReadLine());
       // for (int cardChoice = 0; cardChoice < 52; cardChoice++)  
       // {        
        //if you uncomment the previous 2 lines and the two below,
        //you'll get a program that simply prints all cards.
            cardChoice--;
            int suit = cardChoice / 13;
            int typeOfCard = cardChoice % 13;
            string cardName = "";
            string cardSuit = "";
            switch (typeOfCard)
            {
                case 0: cardName = "Ace"; break;
                case 1: cardName = "Two"; break;
                case 2: cardName = "Three"; break;
                case 3: cardName = "Four"; break;
                case 4: cardName = "Five"; break;
                case 5: cardName = "Six"; break;
                case 6: cardName = "Seven"; break;
                case 7: cardName = "Eight"; break;
                case 8: cardName = "Nine"; break;
                case 9: cardName = "Ten"; break;
                case 10: cardName = "Jack"; break;
                case 11: cardName = "Queen"; break;
                case 12: cardName = "King"; break;
            }
            switch (suit)
            {
                case 0: cardSuit = "of Spades"; break;
                case 1: cardSuit = "of Hearts"; break;
                case 2: cardSuit = "of Diamonds"; break;
                case 3: cardSuit = "of Clubs"; break;
            }
            Console.WriteLine("The {0}. card from an arranged deck (from Ace to King, from Spades to Clubs) is: \n{1} {2}\n",cardChoice +1,cardName,cardSuit);
         //    Console.WriteLine(cardName + " " + cardSuit);
       // }
    }
    }


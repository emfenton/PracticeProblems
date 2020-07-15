using System;

namespace PlayingCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Card firstCard = new Card();
            Console.WriteLine(firstCard.getRank());
        }
    }

    public class Card
    {
        string rank; 
        string color; 
        string suit; 

        public Card()
        {
            rank = "Queen";
            color = "red";
            suit = "hearts";
        }

        public void setCard(string rank, string color, string suit)
        {
            this.rank = rank;
            this.color = color;
            this.suit = suit;
        }

        public string getRank()
        {
            return rank;
        }
        public string getSuit()
        {
            return suit;
        }


    }

}
//specify, design, and implement a class for a card in a deck of playing cards. the class should contain methods for 
//setting and retrieving the suit and rank of a card.


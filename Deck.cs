using System;
using System.Collections.Generic;
using System.Text;
/// </summary>
/// Name:Kobra Nateghi
/// Date: Dec 20, 2019
/// Description: This is the Deck Class
/// It inherits from List generic and uses Card as the base type
/// Version: 0.4 refactored to extends the CardList abstract class
/// </summary>

namespace COMP123_s2019_Lesson11B
{
    public class Deck: CardList
    {
        //private instance variables
        private Random _random;

        //private properties
        private Random Random { get=> this._random; } 
        //public constructor
        /// <summary>
        /// This is the main constructor we take out the default constructor because the initialize method is already
        /// called by the Super class
        /// </summary>
        //public Deck()
        //{
        //    this._initilize();
        //}

        //private methods
        /// <summary>
        /// This is the _initialize methods, it sets variables for private variables
        /// and public properties as well as other class objects
        /// </summary>
        protected override void _initilize()
        {
            //initialize the pseudo-random number generator
            this._random = new Random();
            //this builds the deck-fills it out with cards
            for (int suit = (int)Suit.Clubs; suit <= (int)Suit.Spades; suit++)
            {
                for (int face = (int)Face.Ace; face <= (int)Face.King; face++)
                {
                    this.Add(new Card((Face)face, (Suit)suit));

                }
            }
        }
        /// <summary>
        /// This method overrides the built in ToString() method 
        /// </summary>
        /// <returns>This method returns the current cards in the deck</returns>
            public override string ToString()
            {
            string outputSTring = "";
            foreach(Card card in this)
            {
                outputSTring += " The " + card.Face + " -- " + card.Suit + " \n";
            }
            return outputSTring;
        }

        //public methods
        /// <summary>
        /// This method shuffles the Deck by using random indices to select two cards at a time
        /// it uses a Fisher-Yates like algorithm
        /// </summary>
        public void Shuffle()
        {
            int firstCard;
            int secondCard;
            Card tempCard;
            for(int card = 0; card < this.Count; card++)
            {

                firstCard = this.Random.Next(0, this.Count);
                secondCard = this.Random.Next(0, this.Count);


                tempCard = (Card)this[secondCard].Clone();
                Card.Overwrite(this[secondCard], this[firstCard]);

                Card.Overwrite(this[firstCard], tempCard);


                //or let's try
                //tempCard = (Card)this[firstCard].Clone();
                //Card.Overwrite(this[firstCard], this[secondCard]);

                //Card.Overwrite(this[secondCard], tempCard);





                //this[secondCard].Face = this[firstCard].Face;
                //this[secondCard].Suit = this[firstCard].Suit;

                //this[firstCard].Face = tempCard.Face;
                //this[firstCard].Suit = tempCard.Suit;

            }
        }

    }

    }

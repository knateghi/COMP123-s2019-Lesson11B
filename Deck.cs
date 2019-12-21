using System;
using System.Collections.Generic;
using System.Text;
/// </summary>
/// Name:Kobra Nateghi
/// Date: Dec 20, 2019
/// Description: This is the Deck Class
/// It inherits from List generic and uses Card as the base type
/// Version: 0.1 created the Deck Class
/// </summary>

namespace COMP123_s2019_Lesson11B
{
    public class Deck: List<Card>
    {
        //private instance variables
        //public properties
        //public constructor
        /// <summary>
        /// This is the main constructor
        /// </summary>
        public Deck()
        {
            this._initilize();
        }

        //private methods
        /// <summary>
        /// This is the _initialize methods, it sets variables for private variables
        /// and public properties as well as other class objects
        /// </summary>
        private void _initilize()
        {
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
                outputSTring += " The " + card.Face + " Of " + card.Suit + " \n";
            }
            return outputSTring;
        }

    }
        //public methods


    }

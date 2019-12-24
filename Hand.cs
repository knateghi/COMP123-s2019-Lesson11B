using System;
using System.Collections.Generic;
using System.Text;
/// Name:Kobra Nateghi
/// Date: Dec 20, 2019
/// Description: This is the Hand Class
/// Version: 0.1 created the Hand class
namespace COMP123_s2019_Lesson11B
{
    public class Hand : CardList
    {
        //private instance variables
        //public properties
        //public methods
        /// <summary>
        /// This method overrides the built in ToString() method 
        /// </summary>
        /// <returns>This method returns the current cards in the deck</returns>
        public override string ToString()
        {
            string outputSTring = "";
            outputSTring += " Hand contains  Number of Cards: " + this.Count + "\n";
            outputSTring += "===============================================\n";
            foreach (Card card in this)
            {
                outputSTring += " The " + card.Face + " -- " + card.Suit + " \n";
            }
            return outputSTring;
        }
        protected override void _initilize()
        {
            //STUB
            //this method is empty
        }
    }
}
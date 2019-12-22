using System;
using System.Collections.Generic;
using System.Text;
/// Name:Kobra Nateghi
/// Date: Dec 20, 2019
/// Description: This is the Card Class
/// Version: 0.2 - implemented the ICLonable Interface
/// </summary>
namespace COMP123_s2019_Lesson11B
{
    public class Card :ICloneable
    {
        //private instance variables

        private Face _face; //(think of enums as int)
        private Suit _suit;

        //public properties
        public Face Face { get=>this._face; set=>this._face=value ; }
        public Suit Suit { get => this._suit; set => this._suit = value; }
        //constructors
        /// <summary>
        /// this is the main constructor it takes two arguments- face(Face) and suit(Suit)
        /// </summary>
        /// <param name="face"></param>
        /// <param name="suit"></param>
        public Card(Face face, Suit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        //public methods
        /// <summary>
        /// This method overrides the built int clone method
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Card(this.Face, this.Suit);
        }
        //private methods

    }
}
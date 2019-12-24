using System;
using System.Collections.Generic;
using System.Text;
/// Name:Kobra Nateghi
/// Date: Dec 20, 2019
/// Description: This is the abstract super Class CardList 
/// Version: 0.1 created the card list abstract class
namespace COMP123_s2019_Lesson11B
{
    public abstract class CardList:List<Card>
    {
        //private properties
        //public properties
        //constructor

        //public constructor
        /// <summary>
        /// This is the main constructor
        /// </summary>
        public CardList()
        {
            this._initilize();
        }

        //private methods
        protected abstract void _initilize();
        //public methods

    }
}
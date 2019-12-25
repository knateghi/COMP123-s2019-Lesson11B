using System;
/// <summary>
/// Name:Kobra Nateghi
/// Date: Dec 20, 2019
/// Version: 0.4 Tested the new Deck class
/// </summary>
namespace COMP123_s2019_Lesson11B
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Hand hand = new Hand();
           
            Console.WriteLine(deck.ToString());
            Console.WriteLine( );
            deck.Shuffle();
            Console.WriteLine("shuffled");
            Console.WriteLine(deck.ToString());


            Console.WriteLine();
            hand.Add(deck.Deal1());
            Console.WriteLine(hand.ToString());

            hand.Add(deck.Deal1());
            Console.WriteLine(hand.ToString());

            Console.WriteLine();
            Console.WriteLine(deck.ToString());
        }
    }
}

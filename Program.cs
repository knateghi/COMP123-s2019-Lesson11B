using System;
/// <summary>
/// Name:Kobra Nateghi
/// Date: Dec 20, 2019
/// Version: 0.3 Test the shuffle method
/// </summary>
namespace COMP123_s2019_Lesson11B
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            Console.WriteLine("Original deck: ");
            Console.WriteLine("===============================================");
            Console.WriteLine(deck.ToString());
            Console.WriteLine( );
            deck.Shuffle();
            Console.WriteLine("SHuffles deck: ");
            Console.WriteLine("===============================================");
            Console.WriteLine(deck.ToString());
        }
    }
}

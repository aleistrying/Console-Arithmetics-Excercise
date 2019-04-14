using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCards;

namespace Excercise4C2
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            //prompts for values
            Console.WriteLine("Gimmie values and i'll fill the between");
            Console.WriteLine("Value 1:");
            int firstN = int.Parse(Console.ReadLine());
            Console.WriteLine("Value 2:");
            int secondN = int.Parse(Console.ReadLine());
            //checks if value is higher or lower 
            if (firstN >= secondN)
            {
                for(;firstN >= secondN; firstN--)
                {
                    //prints value if it's higher or equal
                    Console.WriteLine(firstN);
                }
            }
            else
            {
                for (; firstN <= secondN; firstN++)
                {
                    //prints value if it's higher or equal
                    Console.WriteLine(firstN);
                }
            }
            Console.ReadLine();
            List<Card> Hand = new List<Card>();
            deck.Shuffle();
            for(int i = 0; i < 5; i++)
            {
                Hand.Add(deck.TakeTopCard());
            }
            for(int i = 0; i < Hand.Count; i++)
            {
                Hand[i].FlipOver();
            }
            foreach(Card card in Hand)
            {
                card.Print();
            }
            Console.ReadLine();
        }
    }
}

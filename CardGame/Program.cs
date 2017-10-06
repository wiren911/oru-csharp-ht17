using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    enum Color
    {
        Ruter, Klover, Hearts, Spader
    }
    struct Card
    {
        public int Value;
        public Color Color;

        public override string ToString()
        {
            return $"Value: {Value}, Color: {Color}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var cards = AddCardsToDeck();
            var stack = CreateRandomizedStack(cards);

            PopCards(stack, 7);

            Console.ReadKey();
        }

        private static void PopCards(Stack<Card> stack, int cardsToPop)
        {
            for (int i = 0; i < cardsToPop; i++)
            {
                var card = stack.Pop();
                Console.WriteLine(card.ToString());
            }
        }

        private static Stack<Card> CreateRandomizedStack(List<Card> cards)
        {
            var random = new Random();
            var stack = new Stack<Card>();
            for (int j = 0; j < 52; j++)
            {
                var index = random.Next(cards.Count);
                var card = cards[index];
                cards.Remove(card);
                stack.Push(card);
            }
            return stack;
        }

        private static List<Card> AddCardsToDeck()
        {
            var cards = new List<Card>();
            for (int j = 0; j < 4; j++)
            {
                for (int k = 2; k < 13; k++)
                {
                    cards.Add(new Card { Value = k, Color = (Color)j });
                }
            }

            return cards;
        }
    }
}

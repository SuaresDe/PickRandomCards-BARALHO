using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class CardPicker
    {
        static Random Random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i =0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " de " + RandomSuit();
            }
            return pickedCards;
        }
        private static string RandomValue()
        {
            int value = Random.Next(1, 14);
            if (value == 1) return "As";
            if (value == 11) return "Valete";
            if (value == 12) return "Dama";
            if (value == 13) return "Rei";
            return value.ToString();
        }

        private static string RandomSuit()
        {
            int value = Random.Next(1, 5);
            if (value == 1) return "Espadas";
            if (value == 2) return "Copas";
            if (value == 3) return "Paus";
            return "Ouros";
        }
    }
}

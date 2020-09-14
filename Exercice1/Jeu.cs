using System;
using static Exercice1.Dice;

namespace Exercice1
{
    class Jeu
    {
        private int? nbDe;
        private const int maxDiceNumber = 5;
        private const int minDiceNumber = 1;

        public int? NbDe
        {
            get { return nbDe; }
            set
            {
                if (NbDe <= maxDiceNumber && NbDe >= minDiceNumber)
                {
                    nbDe = value;
                }
                else
                {
                    NbDe = null;
                    Console.WriteLine($"Le nombre de dé doit être compris entre 1 et 5.");
                }

            }
        }

        public FacesEnum TypeFace { get; }

    }
}

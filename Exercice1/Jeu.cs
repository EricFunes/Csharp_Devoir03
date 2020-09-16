using System;
using System.Collections.Generic;
using static Exercice1.Dice;

namespace Exercice1
{
    class Game: List<Dice>
    {
        private Random r = new Random();
        private Dictionary<Dice, int> diceTrack;
        private int? myDiceNumber;
        private const int maxDiceNumber = 5;
        private const int minDiceNumber = 1;

        public int? MyDiceNumber
        {
            get { return myDiceNumber; }
            set
            {
                if (value <= maxDiceNumber && value >= minDiceNumber)
                {
                    myDiceNumber = value;
                }
                else
                {
                    myDiceNumber = null;
                    Console.WriteLine($"Le nombre de dé doit être compris entre 1 et 5.");
                }

            }
        }

        public FacesEnum MyFaceType { get; set; }

        public Game(int nbDice, FacesEnum faceType)
        {
            this.MyDiceNumber = nbDice;
            this.MyFaceType = faceType;
            diceTrack = new Dictionary<Dice, int>();

            for (int i = 0; i < MyDiceNumber; i++)
            {
                this.Add(new Dice(faceType, new Dice.ColorEnum()));
            }
        }

        public bool UpdateDiceColor(ColorEnum previousColor, ColorEnum newColor)
        {
            Dice? previousDice = getGameDiceByColor(previousColor);
            if (previousDice == null)
            {
                Console.WriteLine($"Aucun dé de couleur {previousColor} existe dans le jeu.");
                return false;
            }
            this.Remove((Dice)previousDice);
            this.Add(new Dice(MyFaceType, newColor));
            return true;
        }

        public bool ThrowOneDice()
        {

            throw new NotImplementedException();
        }
        public bool ThrowAllDice()
        {

            throw new NotImplementedException();
        }

        public void MyMethod()
        {

            throw new NotImplementedException();
        }
        public string GetDiceTrackResult()
        {

            throw new NotImplementedException();
        }

        private Dice getTrackDiceByColor(ColorEnum color)
        {

            throw new NotImplementedException();
        }
        private Dice? getGameDiceByColor(ColorEnum color)
        {
            Dice? diceFound = null;

            foreach (Dice d in this)
            {
                if (d.MyColor == color)
                {
                    diceFound = d;
                }
            }
            return diceFound;
        }
        public bool ThrowOneTrackDice(ColorEnum color)
        {

            throw new NotImplementedException();
        }
        public string GetSortedDiceTrackResult()
        {

            throw new NotImplementedException();
        }
        public bool SwapDice(ColorEnum previousColor, ColorEnum newColor)
        {

            throw new NotImplementedException();
        }
    }
}
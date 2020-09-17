using System;
using System.Collections.Generic;
using System.Linq;
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
                Dice.ColorEnum color = (Dice.ColorEnum) i;
                this.Add(new Dice(faceType, color));
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
            if (this.Count != 0)
            {
                Dice d = this[0];
                this.Remove(d);
                var result = r.Next(1, (int) d.MyFaceNb);
                this.diceTrack.Add(d, result);
                return true;
            }
            return false;
        }
        public bool ThrowAllDice()
        {
            if (this.Count != 0)
            {
                foreach (Dice d in this.ToList())
                {
                    this.Remove(d);
                    var result = r.Next(1, (int)d.MyFaceNb);
                    this.diceTrack.Add(d, result);
                }
            }
            return true;
        }
        public string GetDiceTrackResult()
        {
            string result = "";

            foreach (KeyValuePair<Dice, int> dice in this.diceTrack)
            {
                result += $"Dé {dice.Key.MyColor} {dice.Value} ";
            }
            return result;
        }

        private Dice? getTrackDiceByColor(ColorEnum color)
        {
            Dice? diceFound = null;

            foreach (KeyValuePair<Dice, int> dice in this.diceTrack)
            {
                if (dice.Key.MyColor == color)
                {
                    diceFound = dice.Key;
                }
            }
            return diceFound;
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
            if (this.diceTrack.Count != 0)
            {
                foreach (KeyValuePair<Dice, int> dice in this.diceTrack)
                {
                    if (dice.Key.MyColor == color)
                    {
                        this.diceTrack.Remove(dice.Key);
                        var result = r.Next(1, (int)dice.Key.MyFaceNb);
                        this.diceTrack.Add(dice.Key, result);
                        return true;
                    }
                }
            }
            return false;
        }
        public string GetSortedDiceTrackResult()
        {

            throw new NotImplementedException();
        }
        public bool SwapDice(ColorEnum previousColor, ColorEnum newColor)
        {
            Dice? firstDice = getTrackDiceByColor(previousColor);
            Dice? secondDice = getTrackDiceByColor(newColor);
            int firstDiceValue = 0;
            int secondDiceValue = 0;

            if (firstDice != null && secondDice != null)
            {
                foreach (KeyValuePair<Dice, int> dice in this.diceTrack)
                {
                    if (dice.Key.Equals((Dice)firstDice))
                    {
                        firstDiceValue = dice.Value;
                    }
                    else if (dice.Key.Equals((Dice)secondDice))
                    {
                        secondDiceValue = dice.Value;
                    }
                }
                this.diceTrack.Remove((Dice)firstDice);
                this.diceTrack.Remove((Dice)secondDice);

                this.diceTrack.Add((Dice)firstDice, secondDiceValue);
                this.diceTrack.Add((Dice)secondDice, firstDiceValue);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
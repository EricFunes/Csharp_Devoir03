using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exercice1.Dice;

namespace Exercice1
{
    class Player
    {
        public Game MyGame { get; }

        public string FullName { get 
            {
                return $"{this.FirstName} {this.LastName}";
            } 
        }
        public string FirstName { get; }
        public string LastName { get; }
        public Player(string firstName, string lastName, int nbDice, FacesEnum face)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MyGame = new Game(nbDice, face);
        }
        public override string ToString()
        {
            return $"{FullName} joue avec {MyGame.MyDiceNumber} dé(s) qui ont {MyGame.MyFaceType} faces.";
        }
    }
}

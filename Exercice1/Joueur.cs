using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    class Joueur
    {
        public Jeu MyGame { get; private set; }

        public string FullName { get 
            {
                return $"{this.FirstName} {this.LastName}";
            } 
        }
        public string FirstName { get; }
        public string LastName { get; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Eric", "Funes", 3, Dice.FacesEnum.quatres);
            Console.WriteLine(player);
        }
    }
}

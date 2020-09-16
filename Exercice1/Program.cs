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
            player.MyGame.ThrowOneDice();
            Console.WriteLine($"Un dé est lancé, TrackResult: {player.MyGame.GetDiceTrackResult()}");
            player.MyGame.UpdateDiceColor(Dice.ColorEnum.JAUNE, Dice.ColorEnum.BLEU);
            Console.WriteLine($"Le dé jaune est désormais bleu! TrackResult: {player.MyGame.GetDiceTrackResult()}");
        }
    }
}

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
            Console.WriteLine($"TrackResult: {player.MyGame.GetDiceTrackResult()}");
            
            player.MyGame.ThrowOneDice();
            Console.WriteLine($"Un dé est lancé, TrackResult: {player.MyGame.GetDiceTrackResult()}");
            
            player.MyGame.UpdateDiceColor(Dice.ColorEnum.JAUNE, Dice.ColorEnum.BLEU);
            Console.WriteLine($"Le dé jaune est désormais bleu! TrackResult: {player.MyGame.GetDiceTrackResult()}");

            player.MyGame.ThrowAllDice();
            Console.WriteLine($"Tous les dés sont lancés! TrackResult: {player.MyGame.GetDiceTrackResult()}");

            player.MyGame.ThrowOneTrackDice(Dice.ColorEnum.VERT);
            Console.WriteLine($"Le dé vert est relancé, TrackResult: {player.MyGame.GetDiceTrackResult()}");

            player.MyGame.SwapDice(Dice.ColorEnum.BLANC, Dice.ColorEnum.VERT);
            Console.WriteLine($"Les résultats des dés BLANC et VERT sont échangés! TrackResult: {player.MyGame.GetDiceTrackResult()}");
        }
    }
}

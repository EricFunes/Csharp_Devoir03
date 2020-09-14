using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    public struct Dice
    {
        public enum ColorEnum
        {
            BLANC, JAUNE, VERT, BLEU, VIOLET, ROUGE, NOIR
        }
        public enum FacesEnum
        {
            trois = 3, quatres = 4, six = 6, huit = 8, dix = 10
        }

        public ColorEnum MyColor { get; set; }
        public FacesEnum MyFaceNb { get; set; }

        public Dice(FacesEnum face, ColorEnum color)
        {
            this.MyFaceNb = face;
            this.MyColor = color;
        }
    }
}
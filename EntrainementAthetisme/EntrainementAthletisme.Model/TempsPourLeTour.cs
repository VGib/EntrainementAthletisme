using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntrainementAthletisme.Model
{
    public class TempsPourLeTour
    {
        public TempsPourLeTour( NiveauEntrainement niveauEntrainementPourLeTour ,double longueurEnM)
        {
            NiveauEntrainementPourLeTour = niveauEntrainementPourLeTour;
            LongueurEnM = longueurEnM;
            Temps = TimeSpan.FromSeconds(LongueurEnM * 3.6d / niveauEntrainementPourLeTour.VitesseKmParHeure);
        }

        public TimeSpan Temps { get;  }
        public NiveauEntrainement NiveauEntrainementPourLeTour { get; }
        public double LongueurEnM { get; }
    }
}

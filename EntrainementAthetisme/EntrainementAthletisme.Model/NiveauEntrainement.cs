using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntrainementAthletisme.Model
{
    public class NiveauEntrainement
    {
        public NiveauEntrainement(NiveauEntrainementLabel label, AthleteStatistiques atheleteStatistiques)
        {
            Label = label;

            FrequenceCardiaque =  label.PourcentageDeLaFrequenceCardiaqueMax  * ( atheleteStatistiques.FrequenceCardiaqueMax - atheleteStatistiques.FrequenceCardiaqueMin ) / 100d + atheleteStatistiques.FrequenceCardiaqueMin;
            VitesseKmParHeure = label.PourcentageDeLaVMA * atheleteStatistiques.VMA / 100d;
            VitesseEnMinParKm = TimeSpan.FromSeconds(1000d * 3.6d / VitesseKmParHeure);
            Puissance = label.PourcentageDeLaPuissance * atheleteStatistiques.PuissanceCritique / 100d;
        }

        public NiveauEntrainementLabel Label { get; }

        public double FrequenceCardiaque { get;  }

        public TimeSpan VitesseEnMinParKm { get;  }

        public double VitesseKmParHeure { get;  }

        public double Puissance { get;  }
    }
}

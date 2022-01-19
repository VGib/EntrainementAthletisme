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

            MinFrequenceCardiaque = label.MinPourcentageDeLaFrequenceCardiaqueMax * (atheleteStatistiques.FrequenceCardiaqueMax - atheleteStatistiques.FrequenceCardiaqueMin) / 100d + atheleteStatistiques.FrequenceCardiaqueMin;
            MaxFrequenceCardiaque = label.MaxPourcentageDeLaFrequenceCardiaqueMax * (atheleteStatistiques.FrequenceCardiaqueMax - atheleteStatistiques.FrequenceCardiaqueMin) / 100d + atheleteStatistiques.FrequenceCardiaqueMin;
            MinVitesseKmParHeure = label.MinPourcentageDeLaVDOT * atheleteStatistiques.GetVDOT().VitesseEnKmParHeure / 100d;
            MaxVitesseKmParHeure = label.MaxPourcentageDeLaVDOT * atheleteStatistiques.GetVDOT().VitesseEnKmParHeure / 100d;
            MinMetreParcourusParSecondes = label.MinPourcentageDeLaVDOT * atheleteStatistiques.GetVDOT().DistanceParcourueEn1s / 100d;
            MinVitesseEnMinParKm = TimeSpan.FromSeconds(1000d / MinMetreParcourusParSecondes);
            MaxMetreParcourusParSecondes = label.MaxPourcentageDeLaVDOT * atheleteStatistiques.GetVDOT().DistanceParcourueEn1s / 100d;
            MaxVitesseEnMinParKm = TimeSpan.FromSeconds(1000d / MaxMetreParcourusParSecondes);
            MinPuissance = label.MinPourcentageDeLaPuissanceCritique * atheleteStatistiques.PuissanceCritique / 100d;
            MaxPuissance = label.MaxPourcentageDeLaPuissanceCritique * atheleteStatistiques.PuissanceCritique / 100d;
        }

        public NiveauEntrainementLabel Label { get; }

        public double MinFrequenceCardiaque { get;  }
        public double MaxFrequenceCardiaque { get; }

        public TimeSpan MinVitesseEnMinParKm { get;  }

        public TimeSpan MaxVitesseEnMinParKm { get; }

        public double MinMetreParcourusParSecondes { get; }

        public double MaxMetreParcourusParSecondes { get; }

        public double MinVitesseKmParHeure { get;  }

        public double MaxVitesseKmParHeure { get; }

        public double MinPuissance { get;  }

        public double MaxPuissance { get; }
    }
}

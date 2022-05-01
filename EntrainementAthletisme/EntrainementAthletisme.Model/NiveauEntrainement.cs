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
         }

        public NiveauEntrainementLabel Label { get; }

        public double MinFrequenceCardiaque { get;  }
        public double MaxFrequenceCardiaque { get; }
    }
}

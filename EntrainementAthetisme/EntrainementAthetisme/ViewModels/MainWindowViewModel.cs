using EntrainementAthletisme.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace EntrainementAthetisme.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public AthleteStatistiques Statistique { get; } = new AthleteStatistiques
        {
            FrequenceCardiaqueMin = 43,
            FrequenceCardiaqueMax = 184,
            PuissanceCritique = 289,
            Temps1500m = new TimeSpan(0,6,26)
        };

        public IEnumerable<NiveauEntrainementLabel> TypeDEntrainements { get; } = new List<NiveauEntrainementLabel>
        { 
           new NiveauEntrainementLabel
           {
               Name = "E/L",
               MinPourcentageDeLaVDOT = 59,
               MaxPourcentageDeLaVDOT = 79,
               MinPourcentageDeLaFrequenceCardiaqueMax = 65,
               MaxPourcentageDeLaFrequenceCardiaqueMax = 79,
               MinPourcentageDeLaPuissanceCritique = 65,
               MaxPourcentageDeLaPuissanceCritique = 80
           },
            new NiveauEntrainementLabel
           {
               Name = "M",
               MinPourcentageDeLaVDOT = 80,
               MaxPourcentageDeLaVDOT = 84,
               MinPourcentageDeLaFrequenceCardiaqueMax = 80,
               MaxPourcentageDeLaFrequenceCardiaqueMax = 89,
               MinPourcentageDeLaPuissanceCritique = 80,
               MaxPourcentageDeLaPuissanceCritique = 90
           },
             new NiveauEntrainementLabel
           {
               Name = "T",
               MinPourcentageDeLaVDOT = 83,
               MaxPourcentageDeLaVDOT = 88,
               MinPourcentageDeLaFrequenceCardiaqueMax = 88,
               MaxPourcentageDeLaFrequenceCardiaqueMax = 92,
               MinPourcentageDeLaPuissanceCritique = 90,
               MaxPourcentageDeLaPuissanceCritique = 100
           },
                new NiveauEntrainementLabel
           {
               Name = "10 km",
               MinPourcentageDeLaVDOT = 89,
               MaxPourcentageDeLaVDOT = 94,
               MinPourcentageDeLaFrequenceCardiaqueMax = 92.5,
               MaxPourcentageDeLaFrequenceCardiaqueMax = 97,
               MinPourcentageDeLaPuissanceCritique = double.NaN,
               MaxPourcentageDeLaPuissanceCritique = double.NaN
           },
            new NiveauEntrainementLabel
           {
               Name = "I",
               MinPourcentageDeLaVDOT = 95,
               MaxPourcentageDeLaVDOT = 100,
               MinPourcentageDeLaFrequenceCardiaqueMax = 97.5,
               MaxPourcentageDeLaFrequenceCardiaqueMax = 100,
               MinPourcentageDeLaPuissanceCritique = double.NaN,
               MaxPourcentageDeLaPuissanceCritique = double.NaN
           },
            new NiveauEntrainementLabel
           {
               Name = "R",
               MinPourcentageDeLaVDOT = 89,
               MaxPourcentageDeLaVDOT = 94,
               MinPourcentageDeLaFrequenceCardiaqueMax = double.NaN,
               MaxPourcentageDeLaFrequenceCardiaqueMax = double.NaN,
               MinPourcentageDeLaPuissanceCritique = 115,
               MaxPourcentageDeLaPuissanceCritique = 300
           }
        };

        public MainWindowViewModel()
        {
            NiveauxDEntrainements = TypeDEntrainements.Select(x => new NiveauEntrainement(x,Statistique)).ToArray();
        }

        public IEnumerable<NiveauEntrainement> NiveauxDEntrainements { get; }
    }
}

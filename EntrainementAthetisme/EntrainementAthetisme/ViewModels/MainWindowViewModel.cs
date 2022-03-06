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
        };

        public IEnumerable<NiveauEntrainementLabel> TypeDEntrainements { get; } = new List<NiveauEntrainementLabel>
        { 
           new NiveauEntrainementLabel
           {
               Name = "E/L",

               MinPourcentageDeLaFrequenceCardiaqueMax = 65,
               MaxPourcentageDeLaFrequenceCardiaqueMax = 79,

           },
            new NiveauEntrainementLabel
           {
               Name = "M",

               MinPourcentageDeLaFrequenceCardiaqueMax = 80,
               MaxPourcentageDeLaFrequenceCardiaqueMax = 89,

           },
             new NiveauEntrainementLabel
           {
               Name = "T",
               MinPourcentageDeLaFrequenceCardiaqueMax = 88,
               MaxPourcentageDeLaFrequenceCardiaqueMax = 92,
           },
                new NiveauEntrainementLabel
           {
               Name = "10 km",
               MinPourcentageDeLaFrequenceCardiaqueMax = 92.5,
               MaxPourcentageDeLaFrequenceCardiaqueMax = 97,
           },
            new NiveauEntrainementLabel
           {
               Name = "I",
               MinPourcentageDeLaFrequenceCardiaqueMax = 97.5,
               MaxPourcentageDeLaFrequenceCardiaqueMax = 100,
           }
        };

        public IEnumerable<NiveauEntrainementLabel> AllureCompetition { get; } = new List<NiveauEntrainementLabel>
        {
             new NiveauEntrainementLabel
           {
               Name = "Marathon",
               MinPourcentageDeLaFrequenceCardiaqueMax = 75,
               MaxPourcentageDeLaFrequenceCardiaqueMax = 85
             },
             new NiveauEntrainementLabel
           {
               Name = "Semi-marathon",
               MinPourcentageDeLaFrequenceCardiaqueMax = 85,
               MaxPourcentageDeLaFrequenceCardiaqueMax = 90
             },
             new NiveauEntrainementLabel
           {
               Name = "10 km",
               MinPourcentageDeLaFrequenceCardiaqueMax = 90,
               MaxPourcentageDeLaFrequenceCardiaqueMax = 94
             }
        };

        public MainWindowViewModel()
        {
            NiveauxDEntrainements = TypeDEntrainements.Select(x => new NiveauEntrainement(x,Statistique)).ToArray();
            NiveauxCompetition = AllureCompetition.Select(x => new NiveauEntrainement(x, Statistique)).ToArray();
        }

        public IEnumerable<NiveauEntrainement> NiveauxDEntrainements { get; }

        public IEnumerable<NiveauEntrainement> NiveauxCompetition { get; }
    }
}

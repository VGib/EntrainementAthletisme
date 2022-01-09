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
            PuissanceCritique = 300,
            VMA = 14.45
        };

        public IEnumerable<NiveauEntrainementLabel> TypeDEntrainements { get; } = new List<NiveauEntrainementLabel>
        { 
            new NiveauEntrainementLabel
            {
                Name = "Vitesse",
                PourcentageDeLaFrequenceCardiaqueMax = 100,
                PourcentageDeLaPuissance = 120,
                PourcentageDeLaVMA = 105
            },
            new NiveauEntrainementLabel
            {
                Name = "Répétition Anaérobique",
                PourcentageDeLaFrequenceCardiaqueMax = 98,
                PourcentageDeLaPuissance = 112,
                PourcentageDeLaVMA = 100
,
            },
            new NiveauEntrainementLabel
            {
                Name = "Fractionné courte distance (5km)",
                PourcentageDeLaFrequenceCardiaqueMax = 96,
                PourcentageDeLaPuissance = 104,
                PourcentageDeLaVMA = 95
,
            },
            new NiveauEntrainementLabel
            {
                Name = "Fractionné moyenne distance (10 km)",
                PourcentageDeLaFrequenceCardiaqueMax = 95,
                PourcentageDeLaPuissance = 100,
                PourcentageDeLaVMA = 90
,
            },
            new NiveauEntrainementLabel
            {
                Name = "Fractionné longue distance (21 km)",
                PourcentageDeLaFrequenceCardiaqueMax = 90,
                PourcentageDeLaPuissance = 94,
                PourcentageDeLaVMA = 85
,
            },
            new NiveauEntrainementLabel
            {
                Name = "Endurance",
                PourcentageDeLaFrequenceCardiaqueMax = 78,
                PourcentageDeLaPuissance = 85,
                PourcentageDeLaVMA = 72
,
            },
             new NiveauEntrainementLabel
            {
                Name = "Endurance légère (Récupération)",
                PourcentageDeLaFrequenceCardiaqueMax = 65,
                PourcentageDeLaPuissance = 75,
                PourcentageDeLaVMA = 65
,
            }
        };

        public MainWindowViewModel()
        {
            NiveauxDEntrainements = TypeDEntrainements.Select(x => new NiveauEntrainement(x,Statistique)).ToArray();
        }

        public IEnumerable<NiveauEntrainement> NiveauxDEntrainements { get; }
    }
}

using EntrainementAthletisme.Model;
using System;

namespace EntrainementAthletisme.Tests
{
    public static class ConstantePourLesTests
    {
        public static readonly NiveauEntrainementLabel Label = new() { Name = "Test", MinPourcentageDeLaFrequenceCardiaqueMax = 88, MaxPourcentageDeLaFrequenceCardiaqueMax = 92, MinPourcentageDeLaPuissanceCritique = 90, MaxPourcentageDeLaPuissanceCritique = 100, MinPourcentageDeLaVDOT = 83, MaxPourcentageDeLaVDOT = 88 };

        public static readonly AthleteStatistiques AthleteStatistiques = new() { PuissanceCritique = 300, FrequenceCardiaqueMax = 190, Temps1500m = new TimeSpan(0,6,0), FrequenceCardiaqueMin = 40 };

    }
}
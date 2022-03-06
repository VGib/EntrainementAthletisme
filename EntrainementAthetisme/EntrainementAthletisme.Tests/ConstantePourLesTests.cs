using EntrainementAthletisme.Model;
using System;

namespace EntrainementAthletisme.Tests
{
    public static class ConstantePourLesTests
    {
        public static readonly NiveauEntrainementLabel Label = new() { Name = "Test", MinPourcentageDeLaFrequenceCardiaqueMax = 88, MaxPourcentageDeLaFrequenceCardiaqueMax = 92};

        public static readonly AthleteStatistiques AthleteStatistiques = new() {  FrequenceCardiaqueMax = 190, FrequenceCardiaqueMin = 40 };

    }
}
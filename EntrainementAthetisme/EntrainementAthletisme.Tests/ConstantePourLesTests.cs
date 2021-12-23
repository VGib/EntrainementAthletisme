using EntrainementAthletisme.Model;

namespace EntrainementAthletisme.Tests
{
    public static class ConstantePourLesTests
    {
        public static readonly NiveauEntrainementLabel Label = new() { Name = "Test", PourcentageDeLaFrequenceCardiaqueMax = 85, PourcentageDeLaPuissance = 90, PourcentageDeLaVMA = 80 };

        public static readonly AthleteStatistiques AthleteStatistiques = new() { PuissanceCritique = 300, FrequenceCardiaqueMax = 190, VMA = 15 };

        public static readonly NiveauEntrainement NiveauEntrainement = new(Label, AthleteStatistiques);
    }
}
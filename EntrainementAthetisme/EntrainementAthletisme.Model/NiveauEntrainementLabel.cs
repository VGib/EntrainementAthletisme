namespace EntrainementAthletisme.Model
{
    public class NiveauEntrainementLabel
    {
        public string Name { get; init; } = String.Empty;
        public double PourcentageDeLaVMA { get; init; }
        public double PourcentageDeLaFrequenceCardiaqueMax { get; init; }
        public double PourcentageDeLaPuissance { get; init; }
    }
}

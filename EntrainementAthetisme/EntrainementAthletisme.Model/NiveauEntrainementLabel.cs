namespace EntrainementAthletisme.Model
{
    public class NiveauEntrainementLabel
    {
        public string Name { get; init; } = String.Empty;
        public double MinPourcentageDeLaVDOT { get; init; }
        public double MaxPourcentageDeLaVDOT { get; init; }
        public double MinPourcentageDeLaFrequenceCardiaqueMax { get; init; }
        public double MaxPourcentageDeLaFrequenceCardiaqueMax { get; init; }
        public double MinPourcentageDeLaPuissanceCritique { get; init; }
        public double MaxPourcentageDeLaPuissanceCritique { get; init; }



    }
}

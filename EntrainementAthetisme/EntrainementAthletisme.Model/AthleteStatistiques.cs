namespace EntrainementAthletisme.Model
{
    public class AthleteStatistiques
    {
        public TimeSpan Temps1500m { get; init; }
        public double FrequenceCardiaqueMax { get; init; }
        public double FrequenceCardiaqueMin { get; init; }

        public double PuissanceCritique { get; init; }

        private VDOT _calculatedVDOTInCache = null;

        public VDOT GetVDOT ()
        {
            if(_calculatedVDOTInCache == null)
            {
                _calculatedVDOTInCache = new VDOT(this);
            }

            return _calculatedVDOTInCache;
        }
    }


    public class VDOT
    {

        public VDOT(AthleteStatistiques athleteStatistiques)
        {
            DistanceParcourueEn1s = 1500d / athleteStatistiques.Temps1500m.TotalSeconds;
            VitesseEnKmParHeure = 3.6d * 1500d / athleteStatistiques.Temps1500m.TotalSeconds;
            VitesseEnMinParKm = athleteStatistiques.Temps1500m / 1.5d;
        }

        public TimeSpan VitesseEnMinParKm { get; }

        public double DistanceParcourueEn1s { get; }

        public double VitesseEnKmParHeure { get; }
    }
}
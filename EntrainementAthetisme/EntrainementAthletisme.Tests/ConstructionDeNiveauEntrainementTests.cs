using EntrainementAthletisme.Model;
using NUnit.Framework;
using System;

namespace EntrainementAthletisme.Tests
{
    public class ConstructionDeNiveauEntrainementTests
    {
        [Test]
        public void LeLabelDoitEtreLeLabelUtilisePourLaConstruction()
        {
            var target = new NiveauEntrainement(ConstantePourLesTests.Label, ConstantePourLesTests.AthleteStatistiques);
            Assert.AreSame(ConstantePourLesTests.Label, target.Label);
        }

        [Test]
        public void LaFrequenceCardiaqueDoitEtreLaFrequenceCardiaqueMaxMultiplieParLePourcentageDEffortDeFrequenceCardiaqueDuLabel()
        {
            var target = new NiveauEntrainement(ConstantePourLesTests.Label, ConstantePourLesTests.AthleteStatistiques);
            Assert.AreEqual(161.5d, target.FrequenceCardiaque);
        }

        [Test]
        public void LaVitesseEnKmParHeureDoitEtreLaVMAMultiplieParLePourcentageDEffortDeVitesseEnKmParHeureDuLabel()
        {
            var target = new NiveauEntrainement(ConstantePourLesTests.Label, ConstantePourLesTests.AthleteStatistiques);
            Assert.AreEqual(12d, target.VitesseKmParHeure);
        }

        [Test]
        public void LaVitesseEnMinParKmDoitEtreLaVMAMultiplieParLePourcentageDEffortDeVitesseEnMinParKmDuLabel()
        {
            var target = new NiveauEntrainement(ConstantePourLesTests.Label, ConstantePourLesTests.AthleteStatistiques);
            Assert.AreEqual(new TimeSpan(0,5,0), target.VitesseEnMinParKm);
        }

        [Test]
        public void LaPuissanceCritiqueDoitEtreLaPuissanceCritiqueMaxMultiplieParLePourcentageDEffortDePuissanceCritiqueDuLabel()
        {
            var target = new NiveauEntrainement(ConstantePourLesTests.Label, ConstantePourLesTests.AthleteStatistiques);
            Assert.AreEqual(270d, target.Puissance);
        }
    }
}
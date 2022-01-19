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

        //https://fr.wikipedia.org/wiki/M%C3%A9thode_Karvonen
        //https://www.montre-cardio-gps.fr/comment-configurer-les-zones-cardio-pour-lentrainement/
        [Test]
        public void LaFrequenceCardiaqueMinDoitEtreCalculeDepuisLaMethodeDeKarvonen()
        {
            var target = new NiveauEntrainement(ConstantePourLesTests.Label, ConstantePourLesTests.AthleteStatistiques);
            Assert.AreEqual(172d, target.MinFrequenceCardiaque);
        }

        //https://fr.wikipedia.org/wiki/M%C3%A9thode_Karvonen
        //https://www.montre-cardio-gps.fr/comment-configurer-les-zones-cardio-pour-lentrainement/
        [Test]
        public void LaFrequenceCardiaqueMaxDoitEtreCalculeDepuisLaMethodeDeKarvonen()
        {
            var target = new NiveauEntrainement(ConstantePourLesTests.Label, ConstantePourLesTests.AthleteStatistiques);
            Assert.AreEqual(178d, target.MaxFrequenceCardiaque);
        }


        [Test]
        public void LaVitesseEnKmParHeureMinDoitEtreLaVMAMultiplieParLePourcentageDEffortDeVitesseEnKmParHeureDuLabel()
        {
            var target = new NiveauEntrainement(ConstantePourLesTests.Label, ConstantePourLesTests.AthleteStatistiques);
            Assert.AreEqual(12.45d, target.MinVitesseKmParHeure);
        }

        [Test]
        public void LaVitesseEnKmParHeureMaxDoitEtreLaVMAMultiplieParLePourcentageDEffortDeVitesseEnKmParHeureDuLabel()
        {
            var target = new NiveauEntrainement(ConstantePourLesTests.Label, ConstantePourLesTests.AthleteStatistiques);
            Assert.AreEqual(13.20d, target.MaxVitesseKmParHeure);
        }

        [Test]
        public void LeNombreDeMetresParcouruParSecondsMinDoitEtreMultiplieParLePourcentageDEffortDeVitesseEnKmParHeureDuLabel()
        {
            var target = new NiveauEntrainement(ConstantePourLesTests.Label, ConstantePourLesTests.AthleteStatistiques);
            Assert.AreEqual(3.4583, Math.Round(target.MinMetreParcourusParSecondes, 4));
        }

        [Test]
        public void LeNombreDeMetresParcouruParSecondsMaxDoitEtreMultiplieParLePourcentageDEffortDeVitesseEnKmParHeureDuLabel()
        {
            var target = new NiveauEntrainement(ConstantePourLesTests.Label, ConstantePourLesTests.AthleteStatistiques);
            Assert.AreEqual(3.6667, Math.Round(target.MaxMetreParcourusParSecondes, 4));
        }


        [Test]
        public void LaVitesseEnMinParKmDoitEtreLaVMAMultiplieParLePourcentageDEffortDeVitesseEnMinParKmDuLabel()
        {
            var target = new NiveauEntrainement(ConstantePourLesTests.Label, ConstantePourLesTests.AthleteStatistiques);
            TempsDoiventEtreEgaux(new TimeSpan(0, 4, 49), target.MinVitesseEnMinParKm);
        }

        [Test]
        public void LaVitesseEnMaxParKmDoitEtreLaVMAMultiplieParLePourcentageDEffortDeVitesseEnMinParKmDuLabel()
        {
            var target = new NiveauEntrainement(ConstantePourLesTests.Label, ConstantePourLesTests.AthleteStatistiques);
            TempsDoiventEtreEgaux(new TimeSpan(0, 4, 33), target.MaxVitesseEnMinParKm);
        }

        private void TempsDoiventEtreEgaux(TimeSpan expected, TimeSpan calculated)
        {
            var expectedInSeconds = Math.Round(expected.TotalSeconds, 0);
            var calculatedInSeconds = Math.Round(calculated.TotalSeconds, 0);

            Assert.AreEqual(expectedInSeconds, calculatedInSeconds);
        }

        [Test]
        public void LaPuissanceCritiqueMinDoitEtreLaPuissanceCritiqueMaxMultiplieParLePourcentageDEffortDePuissanceCritiqueDuLabel()
        {
            var target = new NiveauEntrainement(ConstantePourLesTests.Label, ConstantePourLesTests.AthleteStatistiques);
            Assert.AreEqual(270d, target.MinPuissance);
        }

        [Test]
        public void LaPuissanceCritiqueMaxDoitEtreLaPuissanceCritiqueMaxMultiplieParLePourcentageDEffortDePuissanceCritiqueDuLabel()
        {
            var target = new NiveauEntrainement(ConstantePourLesTests.Label, ConstantePourLesTests.AthleteStatistiques);
            Assert.AreEqual(300d, target.MaxPuissance);
        }
    }
}
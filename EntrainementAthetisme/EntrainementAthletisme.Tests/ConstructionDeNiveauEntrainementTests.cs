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
    }
}
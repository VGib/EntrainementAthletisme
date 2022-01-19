using EntrainementAthletisme.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntrainementAthletisme.Tests
{
    public class ConstructionDeVDOT
    {
        [Test]
        public void LaVDOTDoitEtreLaVitesseMoyenneSur1500mEnKmParHeure()
        {
            var vdot = new VDOT( ConstantePourLesTests.AthleteStatistiques);
            Assert.AreEqual(15, Math.Round(vdot.VitesseEnKmParHeure, 4));

        }

        [Test]
        public void LaVDOTDoitEtreLaVitesseMoyenneSur1500mEmMetreParSeconde()
        {
            var vdot = new VDOT(ConstantePourLesTests.AthleteStatistiques);
            Assert.AreEqual(4.1667, Math.Round(vdot.DistanceParcourueEn1s,4));
        }

        [Test]
        public void LaVDOTDoitEtreLaVitesseMoyenneSur1500mEnMinuteParKm()
        {
            var vdot = new VDOT(ConstantePourLesTests.AthleteStatistiques);
            Assert.AreEqual(new TimeSpan(0,4,0), vdot.VitesseEnMinParKm);
        }
    }
}

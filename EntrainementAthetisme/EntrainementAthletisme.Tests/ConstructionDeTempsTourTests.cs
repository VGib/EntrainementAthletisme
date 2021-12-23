using EntrainementAthletisme.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntrainementAthletisme.Tests
{
    public class ConstructionDeTempsTourTests
    {
        [Test]
        public void LeTempsDuTourDoitEtreLeTempsMisPourParcourirleTourALaVistesseDuViveauDEntrainement()
        {
            var target = new TempsPourLeTour(ConstantePourLesTests.NiveauEntrainement, 400d);
            Assert.AreEqual(new TimeSpan(0, 2, 0), target.Temps);
        }
    }
}

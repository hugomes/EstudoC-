using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssertsNUnit;

namespace AssertsNUnit.Tests
{
    [TestFixture]
    public class DatasEspeciaisTests
    {
        [Test]
        public void DataDeveSerAnoNovo()
        {
            DatasEspeciaisStore sut = new DatasEspeciaisStore();
            var retorno = sut.Data(DatasEspeciais.AnoNovo);
            Assert.That(retorno, Is.EqualTo(new DateTime(2017,1,1,0,0,0,0)));
        }

        [Test]
        public void DataDeveRetornarAnoNovo_ComToleranciaUmDia()
        {
            DatasEspeciaisStore sut = new DatasEspeciaisStore();
            var retorno = sut.Data(DatasEspeciais.AnoNovo);
            Assert.That(retorno, Is.EqualTo(new DateTime(2017, 1, 1, 23, 0, 0, 0)).Within(24).Hours);
            Assert.That(retorno, Is.EqualTo(new DateTime(2017, 1, 1, 23, 0, 0, 0)).Within(TimeSpan.FromHours(24)));
        }
    }
}

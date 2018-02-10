using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssertsNUnit.Tests
{
    [TestFixture]
    public class CalculadoraTests
    {
        [Test]
        public void DeveSomarDoisNumeros()
        {
            var sut = new Calculadora();
            var resultado = sut.Somar(1,2);
            Assert.That(resultado, Is.EqualTo(3));
        }

        [Test]
        public void DeveSomarDecimais()
        {
            var sut = new Calculadora();
            var resultado = sut.SomarDecimais(1.2, 2.3);
            Assert.That(resultado, Is.EqualTo(3.5));
        }

        [Test]
        public void DevoSomarDecimais_ArredondandoDuasCasasDecimais()
        {
            Calculadora sut = new Calculadora();
            double resultado = sut.SomarDecimais(1.1, 2);
            Assert.That(Math.Round(resultado, 2), Is.EqualTo(Math.Round(3.1, 2)));
        }

        [Test]
        public void DevoSomarDecimais_ComToleranciaUmDecimo()
        {
            var sut = new Calculadora();
            var resultado = sut.SomarDecimais(1.1, 2.2);
            Assert.That(resultado, Is.EqualTo(3.3).Within(0.1));
        }

        [Test]
        public void DevoSomarDecimais_UsandoToleranciaPorcentagem()
        {
            Calculadora sut = new Calculadora();
            double resultado = sut.SomarDecimais(50,50);
            Assert.That(resultado, Is.EqualTo(111).Within(10).Percent);
        }

        [Test]
        public void DevoSomarDecimais_NaoBomExemploUsandoWithin()
        {
            Calculadora sut = new Calculadora();
            double resultado = sut.SomarDecimais(2.2,2.3);
            Assert.That(resultado, Is.EqualTo(30).Within(100));
        }

        [Test]
        public void Dividir_DeveLancarExcessaoPrimeiroParametroMaiorQueCem()
        {
            Calculadora sut = new Calculadora();
            Assert.Throws<ArgumentOutOfRangeException>(() => sut.Dividir(200, 20));
        }

        [Test]
        public void Dividir_DeveRetornarParametroUmDivididoPeloParametroDois()
        {
            Calculadora sut = new Calculadora();
            Assert.AreEqual(1, sut.Dividir(20, 20));
        }

        [Test]
        public void Dividir_DeveLancarExcessaoDivideByZero()
        {
            Calculadora sut = new Calculadora();
            Assert.Throws<DivideByZeroException>(() => sut.Dividir(20, 0));
            Assert.That(() => sut.Dividir(20, 0),
                Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Matches<ArgumentOutOfRangeException>(v => v.ParamName == "por"));
        }
    }
}

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Tests
{
    [TestFixture]
    public class CalculadoraTests
    {
        //teste para somar dois numeros
        [Test]
        public void DeveSomarDoisNumeros()
        {
            var sut = new Calculadora();
            var resultado = sut.Somar(5, 5);
            Assert.That(resultado, Is.EqualTo(10));
        }

        //teste para multiplicar dois numeros
        [Test]
        public void DeveMultiplicarDoisNumeros()
        {
            var sut = new Calculadora();
            var resultado = sut.Multiplicar(5, 5);
            Assert.That(resultado, Is.EqualTo(25));
        }

        //teste para dividir dois numeros
        [Test]
        public void DeveDividirDoisNumeros()
        {
            var sut = new Calculadora();
            var resultado = sut.Dividir(15, 5);
            Assert.That(resultado, Is.EqualTo(3));
        }

        //teste para subtrair dois numeros
        [Test]
        public void DeveSubtrairDoisNumeros()
        {
            var sut = new Calculadora();
            var resultado = sut.Subtrair(15, 5);
            Assert.That(resultado, Is.EqualTo(10));
        }
    }
}

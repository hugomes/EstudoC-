using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora;

namespace Calculadora.Test
{
    public class CalculadoraTests
    {
        [TestFixture]
        public class CalculadoraSimplesTests
        {
            //teste para somar dois números
            [Test]
            public void DeveSomarDoisNumeros()
            {
                var sut = new CalculadoraSimples();

                var resultado = sut.Somar(5, 5);

                Assert.That(resultado, Is.EqualTo(10));
            }

            //teste para multiplicar dois números
            [Test]
            public void DeveMultiplicarDoisNumeros()
            {
                var sut = new CalculadoraSimples();

                var resultado = sut.Multiplicar(5, 5);

                Assert.That(resultado, Is.EqualTo(25));
            }
        }
    }
}

using NUnit.Framework;
using System.Collections.Generic;

namespace AssertsNUnit.Tests
{
    [TestFixture]
    public class CaracteristicasJogadorTest
    {
        [Test]
        public void DeveAumentarVidaJogadorAoDormir()
        {
            CaracteristicasJogador sut = new CaracteristicasJogador();
            int vidaAntesDormir = sut.Vida;
            sut.Dormir();
            int vidaDepoisDormir = sut.Vida;
            Assert.That(vidaAntesDormir, Is.LessThan(vidaDepoisDormir));
        }

        [Test]
        public void DevePerderVida()
        {
            CaracteristicasJogador sut = new CaracteristicasJogador();
            int vidaAntesPerder = sut.Vida;
            sut.PerderVida(20);
            int vidaDepoisPerder = sut.Vida;
            Assert.That(vidaAntesPerder, Is.GreaterThan(vidaDepoisPerder));
        }

        [Test]
        public void DeveCriarJogadorCom_Nome_Armas_Vida_Novato()
        {
            CaracteristicasJogador sut = new CaracteristicasJogador();

            //precisa ser um novato
            Assert.IsTrue(sut.Novato);

            string[] nomesPossiveis = new[] { "Hugo", "Carlos", "Mario" };
            //o nome precisa ser um dos nomes do array de nomes
            Assert.Contains(sut.Nome, nomesPossiveis);

            //precisa começar com vida maior que 0
            Assert.Greater(sut.Vida,0);

            List<string> armasIniciais = new List<string> { "Revólver", "Faca", "Metralahadora", "Granada" };
            Assert.That(sut.Armas, Is.All.Not.Empty);
            Assert.AreEqual(sut.Armas, armasIniciais);
        }

        [Test]
        public void AsInstanciasDoObjetoJogadorDevemSerIguais()
        {
            CaracteristicasJogador caracteristica1 = new CaracteristicasJogador();
            CaracteristicasJogador caracteristica2 = new CaracteristicasJogador();
            Assert.AreSame(caracteristica1.GetType(), caracteristica2.GetType());
            Assert.IsInstanceOf<CaracteristicasJogador>(caracteristica1);
        }
    }
}

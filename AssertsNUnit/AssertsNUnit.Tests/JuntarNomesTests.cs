using NUnit.Framework;

namespace AssertsNUnit.Tests
{
    [TestFixture]
    public class JuntarNomesTests
    {
        //deve comparar se duas string diferentes tem o mesmo conteudo
        [Test]
        public void DeveConcatenarNomeSobrenome()
        {
            var sut = new JuntarNomes();
            string retorno = sut.ConcatenarNomeSobrenome("Hugo","Gomes");
            Assert.That(retorno, Is.EqualTo("Hugo Gomes"));
        }

        //deve testar se duas string são iguais, ignorando o case sensitive
        [Test]
        public void DeveConcatenarNomeSobrenome_CaseSensitive()
        {
            var sut = new JuntarNomes();
            string retorno = sut.ConcatenarNomeSobrenome("hugo", "gomes");
            Assert.That(retorno, Is.EqualTo("Hugo Gomes").IgnoreCase);
        }


        [Test]
        public void DeveLimparNomeSobrenomeSeFalhar()
        {
            var sut = new JuntarNomes();
            string retorno = sut.ConcatenarNomeSobrenome("Hugo", "Gomes");
            Assert.That(retorno, Is.Not.EqualTo("Mario"));
        }

    }
}

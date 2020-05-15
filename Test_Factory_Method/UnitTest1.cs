using NUnit.Framework;
using factory_method;
namespace Test_Factory_Method
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAguardiente()
        {
            BebidaEmbriagante bebida = Creador.creador(Creador.AGUARDIENTE);
            Assert.AreEqual(bebida.CuantoEmbriaga(),60);
        }

        [Test]
        public void TestVino()
        {
            BebidaEmbriagante bebida = Creador.creador(Creador.VINO);
            Assert.AreEqual(bebida.CuantoEmbriaga(), 40);
        }
    }
}
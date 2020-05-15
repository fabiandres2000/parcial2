using NUnit.Framework;
using Decorador;
namespace Test_Decorador
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void autosindecorar()
        {
            Automovil monovolumen = new Monovolumen();
            Automovil sedan = new Sedan();
            Assert.AreEqual(monovolumen.Descripcion(),"Monovolumen");
            Assert.AreEqual(sedan.Descripcion(), "Sedan");
            Assert.AreEqual(monovolumen.Consumo(),7.5);
            Assert.AreEqual(sedan.Consumo(),6.2);
            Assert.AreEqual(monovolumen.VelocidadMaxima(), 160);
            Assert.AreEqual(sedan.VelocidadMaxima(), 180);
        }

        [Test]
        public void autodecorado()
        {
            Automovil monovolumen = new Monovolumen();
            Automovil sedan = new Sedan();
            //decoro los autos
            monovolumen = new GasolinaDecorador(monovolumen);
            sedan = new ElectricoDecorador(sedan);
           
            Assert.AreEqual(monovolumen.Descripcion(), "Monovolumen Gasolina");
            Assert.AreEqual(sedan.Descripcion(), "Sedan Electrico");
            Assert.AreEqual(monovolumen.Consumo(), 8.5);
            Assert.AreEqual(sedan.Consumo(), 5.2);
            Assert.AreEqual(monovolumen.VelocidadMaxima(), 240);
            Assert.AreEqual(sedan.VelocidadMaxima(), 200);
        }
    }
}
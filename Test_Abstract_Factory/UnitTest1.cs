using NUnit.Framework;
using Abstract_Factory;

namespace Test_Abstract_Factory
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {   
        }

        [Test]
        public void fabricardvdsimple()
        {  
            IFabricaDiscos fabrica;
            Dvd dvd;
            fabrica = new FabricaDiscosSimple();
            dvd = fabrica.CrearDvd();
            Assert.AreEqual(dvd.Capacidad(), "4 GB");
        }

        [Test]
        public void fabricardvddoble()
        {
            IFabricaDiscos fabrica;
            Dvd dvd;
            fabrica = new FabricaDiscosDoble();
            dvd = fabrica.CrearDvd();
            Assert.AreEqual(dvd.Capacidad(), "8 GB");
        }

        [Test]
        public void fabricarbluraysimple()
        {
            IFabricaDiscos fabrica;
            BluRay bluRay;
            fabrica = new FabricaDiscosSimple();
            bluRay = fabrica.CrearBlueRay();
            Assert.AreEqual(bluRay.Capacidad(), "7 GB");
        }

        [Test]
        public void fabricarbluraydoble()
        {
            IFabricaDiscos fabrica;
            BluRay bluRay;
            fabrica = new FabricaDiscosDoble();
            bluRay = fabrica.CrearBlueRay();
            Assert.AreEqual(bluRay.Capacidad(), "14 GB");
        }
    }
}
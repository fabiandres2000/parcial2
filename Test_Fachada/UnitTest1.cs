using NUnit.Framework;
using Fachada;
namespace Test_Fachada
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void compracorrecta()
        {
            Fachada.Fachada Fachada = new Fachada.Fachada();
            string respuesta = Fachada.Compra();
            Assert.AreEqual(respuesta, "su pedido ha sido enviado");
        }

        [Test]
        public void compraincorrecta()
        {
            Fachada.Fachada Fachada = new Fachada.Fachada();
            string respuesta = Fachada.Compra();
            string respuesta1 = Fachada.Compra();
            string respuesta2 = Fachada.Compra();
            string respuesta3 = Fachada.Compra();
            Assert.AreEqual(respuesta3, "no se pudo enviar el articulo, no hay cantidad");
        }
    }
}
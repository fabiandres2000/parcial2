using NUnit.Framework;
using Observador;
namespace Test_Observador
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void cambiospush()
        {
            Sujeto sujeto = new Sujeto();
            Observador.Observador A = new Observador.Observador("A", sujeto);
            Observador.Observador B = new Observador.Observador("B", sujeto);
            Observador.Observador C = new Observador.Observador("C", sujeto);

            for (int n = 0; n < 5; n++)
            {
                sujeto.Trabajo();
            }
        }
    }
}
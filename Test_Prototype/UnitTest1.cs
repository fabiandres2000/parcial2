using NUnit.Framework;
using Prototype;
namespace Test_Prototype
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Prototype()
        {

            Documento documento = new Documento { Pagina = 4,TipoDocumento="articulo",NumeroHojas="4",Texto = "documento numero 1" };
            Documento Documentoclone = documento.Clone() as Documento;
            Documentoclone.Texto = "documento numero 2";
            Documentoclone.TipoDocumento = "ensayo";
            Assert.Pass("documento numero 1", documento.Texto);
            Assert.Pass("documento numero 2", Documentoclone.Texto);
            Assert.Pass("ensayo", Documentoclone.TipoDocumento);
        }
    }
}
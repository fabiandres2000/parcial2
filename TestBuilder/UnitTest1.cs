using NUnit.Framework;
using Builder;
namespace TestBuilder
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void cuatroquesos()
        {
            var preparar = new Preparar();
            preparar.RecepcionarProximaPizza(new CuatroQueso("Familiar"));
            preparar.CocinarPizzaPasoAPaso();
            var pizzaCuatroQuesos = preparar.PizzaPreparada;
            Assert.AreEqual(pizzaCuatroQuesos.Relleno, "mozzarela+gorgonzola+parmesano+ricotta");
        }
        [Test]
        public void hawaiiana()
        {
            var preparar = new Preparar();
            preparar.RecepcionarProximaPizza(new Hawaiiana("Familiar"));
            preparar.CocinarPizzaPasoAPaso();
            var pizzaCuatroQuesos = preparar.PizzaPreparada;
            Assert.AreEqual(pizzaCuatroQuesos.Relleno, "piña+tomate+jamón");
        }

    }
}
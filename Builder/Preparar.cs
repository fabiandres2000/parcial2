using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Preparar
    {
        private PizzaBuilder _pizzaBuilder;

        public void RecepcionarProximaPizza(PizzaBuilder pizzaBuilder)
        {
            _pizzaBuilder = pizzaBuilder;
        }

        public void CocinarPizzaPasoAPaso()
        {
            _pizzaBuilder.PasoPrepararMasa();
            _pizzaBuilder.PasoAñadirSalsa();
            _pizzaBuilder.PasoPrepararRelleno();
        }

        public Pizza PizzaPreparada
        {
            get { return _pizzaBuilder.ObtenerPizza(); }

        }
    }
}

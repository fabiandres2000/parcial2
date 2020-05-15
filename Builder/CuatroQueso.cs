using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class CuatroQueso : PizzaBuilder
    {
        public CuatroQueso(string tamaño)
        {
            _pizza = new Pizza
            {
                Tamaño = tamaño
            };
        }
        public override void PasoPrepararMasa()
        {
            _pizza.Masa = "Cocido";
        }

        public override void PasoAñadirSalsa()
        {
            _pizza.Salsa = "Roquefort";
        }

        public override void PasoPrepararRelleno()
        {
            _pizza.Relleno = "mozzarela+gorgonzola+parmesano+ricotta";
        }
    }
}

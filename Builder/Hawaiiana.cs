using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Hawaiiana : PizzaBuilder
    {
        
            public Hawaiiana(string tamaño)
            {
                 _pizza = new Pizza
                {
                    Tamaño = tamaño
                };
            }
            public override void PasoPrepararMasa()
            {
                _pizza.Masa = "Suave";
            }

            public override void PasoAñadirSalsa()
            {
                _pizza.Salsa = "Dulce";
            }

            public override void PasoPrepararRelleno()
            {
                _pizza.Relleno = "piña+tomate+jamón";
            }
        }
    }


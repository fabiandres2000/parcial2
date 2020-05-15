using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    public class Sedan : Automovil
    {
        public Sedan()
        {
            descripcion = "Sedan";
        }

        public override int VelocidadMaxima()
        {
            return 180;
        }

        public override double Consumo()
        {
            return 6.2;
        }
    }
}

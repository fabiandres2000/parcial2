using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    public class Monovolumen : Automovil
    {
        public Monovolumen()
        {
            descripcion = "Monovolumen";
        }

       
        public override int VelocidadMaxima()
        {
            return 160;
        }

       
        public override double Consumo()
        {
            return 7.5;
        }
    }
}

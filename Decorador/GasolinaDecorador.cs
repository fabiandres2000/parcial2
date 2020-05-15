using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    public class GasolinaDecorador : Decorador
    {
      
        private Automovil vehiculo;

        
        public GasolinaDecorador(Automovil vehiculo)
        {
            this.vehiculo = vehiculo;
        }

       
        public override string Descripcion()
        {
            return vehiculo.Descripcion() + " Gasolina";
        }

      
        public override int VelocidadMaxima()
        {
            return vehiculo.VelocidadMaxima() + 80;
        }

        public override double Consumo()
        {
            return vehiculo.Consumo() + 1;
        }
    }
}

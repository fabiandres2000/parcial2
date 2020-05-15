using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    public class ElectricoDecorador: Decorador
    {
       
           
            private Automovil vehiculo;

            public ElectricoDecorador(Automovil vehiculo)
            {
                this.vehiculo = vehiculo;
            }

           
            public override string Descripcion()
            {
                return vehiculo.Descripcion() + " Electrico";
            }

            public override int VelocidadMaxima()
            {
                return vehiculo.VelocidadMaxima() + 20;
            }

            public override double Consumo()
            {
                return vehiculo.Consumo() - 1;
            }
        }
    }


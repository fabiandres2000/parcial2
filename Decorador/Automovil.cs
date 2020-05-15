using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    public abstract class Automovil
    {
      
            
            protected string descripcion = "Automovil genérico";

            
            public virtual string Descripcion()
            {
                return descripcion;
            }

           
            public abstract int VelocidadMaxima();
            public abstract double Consumo();
        
    }
}

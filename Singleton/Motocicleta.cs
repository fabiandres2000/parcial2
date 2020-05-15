using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Motocicleta
    {
       
            private static Motocicleta instancia;
            // ----------------------------------------
            private Motocicleta()
            {
            }
            // ----------------------------------------
            public static Motocicleta getInstancia()
            {
                    if (instancia == null)
                    {
                        instancia = new Motocicleta();
                       throw new InvalidOperationException ("El objeto ha sido creado");
                    }
                    else
                    {
                       throw new InvalidOperationException("Ya existe el objeto");
                    }
                }
            }
        
    }


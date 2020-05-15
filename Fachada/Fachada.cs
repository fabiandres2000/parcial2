using System;
using System.Collections.Generic;
using System.Text;

namespace Fachada
{
    public class Fachada
    {
        Almacen Almacen = new Almacen();
        Compra Compraa = new Compra();
        Envio Envio = new Envio();

        public string Compra()
        {
            if (Compraa.Comprar(12345))
            {
                if (Almacen.Sacar())
                {
                   return  Envio.EnviarPedido();
                }
                else
                {
                   return ("no se pudo enviar el articulo, no hay cantidad");
                }  
            }
            return null;
        }      
        }
    }


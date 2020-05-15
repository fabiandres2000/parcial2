using System;
using System.Collections.Generic;
using System.Text;

namespace Fachada
{
    public class Compra
    {
        public bool Comprar(int numerotarjeta)
        {
            if (numerotarjeta==12345)
            {
                Console.WriteLine("pago aceptado");
                return true;
            }
            else
            {
                Console.WriteLine("pago rechazado");
                return false;
            }
        }
    }
}

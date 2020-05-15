using System;
using System.Collections.Generic;
using System.Text;

namespace Fachada
{
    public class Almacen
    {
        public int Cantidad;

        public Almacen()
        {
            Cantidad = 3;
        }

        public bool Sacar()
        {
            if (Cantidad>0)
            {
                Cantidad--;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

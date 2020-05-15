using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    public abstract class Disco
    {


        public abstract  string Capacidad();

        public abstract String Nombre();

 
        public String toString()
        {
            return Nombre() + "," + Capacidad();
        }
    }
}


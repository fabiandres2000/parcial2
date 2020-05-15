using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
   public class DvdSimple : Dvd
    {
        public override String Capacidad()
        {
            return "4 GB";
        }

      
        public override String Nombre()
        {
            return "DVD";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

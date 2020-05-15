using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    public class DvdDoble : Dvd
    {
        public override String Capacidad()
        {
            return "8 GB";
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

using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    public class BluRayDoble : BluRay
    {
        public override String Capacidad()
        {
            return "14 GB";
        }


        public override String Nombre()
        {
            return "BluRay";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

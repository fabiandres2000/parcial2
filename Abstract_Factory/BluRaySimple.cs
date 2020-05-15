using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    public class BluRaySimple : BluRay
    {
        public override String Capacidad()
        {
            return "7 GB";
        }

       
        public override  String Nombre()
        {
            return "BluRay";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

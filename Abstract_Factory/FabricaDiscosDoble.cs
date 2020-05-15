using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    public class FabricaDiscosDoble : IFabricaDiscos
    {
        public BluRay CrearBlueRay()
        {
            return new BluRayDoble();
        }



        public virtual Dvd CrearDvd()
        {
            return new DvdDoble();
        }


    }
}

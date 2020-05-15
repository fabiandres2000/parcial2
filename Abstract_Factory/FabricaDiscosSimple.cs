using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    public class FabricaDiscosSimple: IFabricaDiscos
    {
        public BluRay CrearBlueRay()
        {
            return new BluRaySimple();
        }

       
       public virtual Dvd CrearDvd()
        {
            return new DvdSimple();
        }

        
    }
}


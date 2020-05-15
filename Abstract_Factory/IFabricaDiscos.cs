﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    public interface IFabricaDiscos
    {
        public BluRay CrearBlueRay();
        public Dvd CrearDvd();
    }
}

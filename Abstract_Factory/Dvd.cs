﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    public class Dvd : Disco
    {
        public override string Capacidad()
        {
            throw new NotImplementedException();
        }

        public override string Nombre()
        {
            throw new NotImplementedException();
        }
    }
}

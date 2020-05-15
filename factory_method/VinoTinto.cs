using System;
using System.Collections.Generic;
using System.Text;

namespace factory_method
{
    public class VinoTinto : BebidaEmbriagante
    {
        public override double CuantoEmbriaga()
        {
            return 40;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace factory_method
{
    public  class Creador
    {
        public const int VINO = 1;
        public const int AGUARDIENTE = 2;

        public static BebidaEmbriagante creador (int tipo)
        {
            switch (tipo)
            {
                case VINO:
                    return new VinoTinto();
                case AGUARDIENTE:
                    return new Aguardiente();
                default:
                    return null;
            }
        }

    }
}

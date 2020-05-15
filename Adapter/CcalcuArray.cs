using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
   public  class CcalcuArray
    {
        //clase que queremos adaptar, el cliente no la puede usar directamente
        //su interfaz es diferente
        public double Sumar(int[] operandos)
        {
            int n = 0;
            int r = 0;
            for (n=0;n<operandos.Length;n++)
            {
                r += operandos[n];
            }
            return r;
        }
    }
}

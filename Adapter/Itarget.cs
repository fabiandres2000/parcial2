using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public interface Itarget
    {
        //interfaz que conoce el cliente
        public int Suma(int a, int b);
    }
}

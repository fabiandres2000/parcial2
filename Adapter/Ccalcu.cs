using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
   public class Ccalcu : Itarget
    {
        public int suma(int a, int b)
        {
            return a + b;
        }
    }
}

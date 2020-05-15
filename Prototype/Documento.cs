using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Documento :ICloneable
    {
        public int Pagina { get; set; }
        public string Texto { get; set; }
        public string NumeroHojas { get; set; }
        public string TipoDocumento { get; set; }

        public object Clone() {
            
            return this.MemberwiseClone();
        }
    }
  
}

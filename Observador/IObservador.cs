using System;
using System.Collections.Generic;
using System.Text;

namespace Observador
{
    public interface IObservador
    {
        void Update(string mensaje);
        void UpdatePull(); 
    }
}

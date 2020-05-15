using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public  interface IComponente<T>
    {
        T Nombre { get; set; }
        void Adicionar(IComponente<T> elemento);
        string Mostrar(int profundidad);
    }
}

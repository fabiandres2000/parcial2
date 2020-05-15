using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Decorador
{
    public  interface IComponente<T>
    {
        T Nombre { get; set; }
        void Adicionar(IComponente<T> elemento);
        void Mostra(int profundidad);
    }
}

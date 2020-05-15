using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Composite
{
    public class Componente<T> : IComponente<T>
    {
        public T Nombre { get; set; }

        public Componente(T nombre)
        {
            Nombre = nombre;
        }
        public void Adicionar(IComponente<T> elemento)
        {
            Console.WriteLine("solo se adiciona a los compuestos");
        }

        public string Mostrar(int profundidad)
        {
            return new string('-',profundidad)+Nombre+"\n\r";
        }
    }
}

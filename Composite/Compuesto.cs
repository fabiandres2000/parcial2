using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Composite
{
    public class Compuesto<T> : IComponente<T>
    {
        List<IComponente<T>> elementos;
        public T Nombre { get; set; }

        public Compuesto(T nombre)
        {
            Nombre = nombre;
            elementos = new List<IComponente<T>>();
        }

        public void Adicionar(IComponente<T> elemento)
        {
            elementos.Add(elemento);
        }

        public string Mostrar(int profundidad)
        {
            StringBuilder infoelemento = new StringBuilder(new string('-', profundidad));
            infoelemento.Append("compuesto " + Nombre + " elementos: " + elementos.Count+ "\n\r");
            foreach (IComponente<T> elemento in elementos)
                infoelemento.Append(elemento.Mostrar(profundidad + 1));
            return infoelemento.ToString();
        }
    }
}

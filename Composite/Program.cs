using System;
using System.ComponentModel;
using System.Net.Http.Headers;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponente<string> arbol = new Compuesto<string>("root");
            IComponente<string> trabajo = arbol;
            //adicionar componente 
            trabajo.Adicionar(new Componente<string>("root1"));
            trabajo.Adicionar(new Componente<string>("root2"));
            //adicionar compuesto
            IComponente<string> c = new Compuesto<string>("root1");
            trabajo.Adicionar(c);
            trabajo = c;
           //adicionar componente 
            trabajo.Adicionar(new Componente<string>("root11"));
            trabajo.Adicionar(new Componente<string>("root12"));
            //mostrar 

            Console.WriteLine(arbol.Mostrar(0));

        }
    }
}

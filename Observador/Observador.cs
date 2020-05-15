using System;
using System.Collections.Generic;
using System.Text;

namespace Observador
{
    public class Observador:IObservador
    {
        private string Nombre;
        private Sujeto sujeto;

        public Observador(string nombre, Sujeto psujeto)
        {
            Nombre = nombre;
            sujeto = psujeto;
            sujeto.Suscribir(this);
        }

        public void Update(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("push,{0}-{1}",Nombre,mensaje);
        }

        public void UpdatePull()
        {
            int n = sujeto.N;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("pull, {0}-{1}", Nombre, n);
        }
    }
}

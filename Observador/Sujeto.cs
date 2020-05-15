using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Observador
{
    public class Sujeto
    {
        public List<IObservador> Observadores = new List<IObservador>();
        private string Mensaje;
        private Random Random = new Random();
        private int n;
        public int N { get => n; set => n=value; }

        public void Suscribir(IObservador suscrito)
        {
            Observadores.Add(suscrito);
        }

        private void  Notificar()
        {
            foreach (IObservador o in Observadores)
            {
                o.Update(Mensaje);
            }
        }
        public void Trabajo()
        {
            n = Random.Next(10);
            if (n%2==0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---Nuevo estado valido---");
                Mensaje = string.Format("el nuevo valor es {0} ",n);
                Notificar();
            }
        }
    }
}

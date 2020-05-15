using System;

namespace Observador
{
    class Program
    {
        static void Main(string[] args)
        {
            Sujeto sujeto = new Sujeto();
            Observador A = new Observador("A",sujeto);
            Observador B = new Observador("B", sujeto);
            Observador C = new Observador("C", sujeto);

            for (int n=0;n<5;n++)
            {
                sujeto.Trabajo();
            }
        }
    }
}

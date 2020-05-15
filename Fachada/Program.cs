using System;

namespace Fachada
{
    class Program
    {
        static void Main(string[] args)
        {
            Fachada Fachada = new Fachada();
            Console.WriteLine("--------------------");
            Fachada.Compra();
            Console.WriteLine("--------------------");
            Fachada.Compra();
            Console.WriteLine("--------------------");
            Fachada.Compra();
            Console.WriteLine("--------------------");
            Fachada.Compra();
        }
    }
}

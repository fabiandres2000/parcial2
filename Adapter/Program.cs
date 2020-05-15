using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = 0;
            //este es el cliente
            Itarget calcu = new Ccalcu();
            //usamos la interfaz que el cliente conoce con una clace que conoce
            resultado = calcu.suma(3,4);
            Console.WriteLine("el resultado de la suma es: {0}",resultado);
            Console.WriteLine("-----------------------------------");
            //hacemos el uso del adaptador
            calcu = new Adaptador();
            //usamos el adaptador para hacer la operacion
            resultado = calcu.suma(5,6);
            Console.WriteLine("el resultado de la suma es: {0}", resultado);
            Console.WriteLine("-----------------------------------");
        }
    }
}

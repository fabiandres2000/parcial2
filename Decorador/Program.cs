using System;

namespace Decorador
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil monovolumen = new Monovolumen();
            Automovil sedan = new Sedan();
            MostrarCaracteristicas(monovolumen); 
            MostrarCaracteristicas(sedan);
            monovolumen = new GasolinaDecorador(monovolumen);
            MostrarCaracteristicas(monovolumen);
            sedan = new ElectricoDecorador(sedan);
            MostrarCaracteristicas(sedan);
        }

        private static void MostrarCaracteristicas(Automovil v)
        {
            Console.WriteLine(string.Format("{0}\n\t- Velocidad punta de {1} km/h \n\tConsumo medio de {2} l/100km\n",
                                            v.Descripcion(),
                                            v.VelocidadMaxima(),
                                            v.Consumo()));
        }
    }
}

using System;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFabricaDiscos fabrica;
            Dvd dvd;
            BluRay bluray;

            fabrica = new FabricaDiscosSimple();
            dvd = fabrica.CrearDvd();
            bluray = fabrica.CrearBlueRay();

            Console.WriteLine(dvd);
            Console.WriteLine(bluray);

            fabrica = new FabricaDiscosDoble();
            dvd = fabrica.CrearDvd();
            bluray = fabrica.CrearBlueRay();

            Console.WriteLine(dvd);
            Console.WriteLine(bluray);

        }
    }
}

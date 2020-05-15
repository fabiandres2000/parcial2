using NUnit.Framework;
using Adapter;
using System;
namespace Test_Adaptador
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
          
        }

        [Test]
        public void Test1()
        {  
            int resultado = 0;
            //este es el cliente
            Itarget calcu = new Ccalcu();
            //usamos la interfaz que el cliente conoce con una clace que conoce
            resultado = calcu.Suma(3, 4);
            Console.WriteLine("el resultado de la suma es: {0}", resultado);
            Console.WriteLine("-----------------------------------");
            Assert.AreEqual(resultado,7);
        }

        [Test]
        public void Test2()
        {
            int resultado = 0;
            //este es el cliente
            Itarget calcu = new Ccalcu();
            //hacemos el uso del adaptador
            calcu = new Adaptador();
            //usamos el adaptador para hacer la operacion
            resultado = calcu.Suma(5, 6);
            Console.WriteLine("el resultado de la suma es: {0}", resultado);
            Assert.AreEqual(resultado, 11);
        }
    }
}
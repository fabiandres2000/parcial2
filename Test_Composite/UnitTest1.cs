using NUnit.Framework;
using Composite;
using System;

namespace Test_Composite
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
            Assert.Pass();
        }
    }
}
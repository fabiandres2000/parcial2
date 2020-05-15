using NUnit.Framework;
using System;
using Singleton;

namespace Test_Singleton
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1Singleton()
        {
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => Singleton.Motocicleta.getInstancia());
           Assert.AreEqual(ex.Message,"El objeto ha sido creado");        
        }

        [Test]
        public void Test2Singleton()
        {
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => Singleton.Motocicleta.getInstancia());
            InvalidOperationException x = Assert.Throws<InvalidOperationException>(() => Singleton.Motocicleta.getInstancia());
            Assert.AreEqual(x.Message, "Ya existe el objeto");
        }
    }
}
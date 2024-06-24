using System;
using ClassLibraryCalculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCalculadora
{
    [TestClass]
    public class UnitTest1
    {
        private readonly int nro1 = 3;
        private readonly int nro2 = 0;

        Operaciones operacion = new Operaciones();

        [TestMethod]
        public void Sumar()
        {
            int resultado = operacion.Sumar(nro1, nro2);
            Assert.AreEqual(31, resultado);
            Console.WriteLine($@"{nro1} + {nro2}: {resultado} - Valor Esperado: 31");
        }
        
        [TestMethod]
        public void Restar()
        {
            int resultado = operacion.Restar(nro1, nro2);
            Assert.AreEqual(30, resultado);
            Console.WriteLine($@"{nro1} - {nro2}: {resultado} - Valor Esperado: 30");

        }

        [TestMethod]
        public void Multiplicar()
        {
            int resultado = operacion.Multiplicar(nro1, nro2);
            Assert.AreEqual(31, resultado);
            Console.WriteLine($@"{nro1} * {nro2}: {resultado} - Valor Esperado: 31");
        }

        [TestMethod]
        public void Dividir()
        {
            float resultado = operacion.Dividir(nro1, nro2);
            Assert.AreEqual(3, resultado);
            Console.WriteLine($@"{nro1} / {nro2}: {resultado} - Valor Esperado: 3");

        }


    }
}

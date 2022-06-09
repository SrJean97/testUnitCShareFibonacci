using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AuthTestFibonacci
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Prueba0()
        {
            int result = Fibonacci.Program.SerieFibonacci(0);
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void Prueba1()
        {
            int result = Fibonacci.Program.SerieFibonacci(1);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void Prueba2()
        {
            int result = Fibonacci.Program.SerieFibonacci(4);
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void Prueba3()
        {
            int result = Fibonacci.Program.SerieFibonacci(10);
            Assert.AreEqual(8, result);
        }
        [TestMethod]
        public void Prueba4()
        {
            int result = Fibonacci.Program.SerieFibonacci(50);
            Assert.AreEqual(120, result);
        }
    }
}

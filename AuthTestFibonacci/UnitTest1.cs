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
    }
}

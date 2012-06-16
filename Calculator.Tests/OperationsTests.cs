using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void CanSum()
        {
            Assert.That(Operations.Sum(1, 1) == 2);
        }

        [Test]
        public void CanDivide()
        {
            Assert.That(Operations.Divide(1, 1) == 1);
        }
    }
}

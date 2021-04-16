using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab_2.Tests
{
    [TestClass]
    public class SubSystemATestsBase
    {
        [TestMethod()]
        public void OperationATest()
        {
            SubSystemA subSystemA = new SubSystemA();
            string actual = subSystemA.OperationA();
            string expected = "SubSystem A";
            Assert.ReferenceEquals(actual, expected);
        }
    }
}
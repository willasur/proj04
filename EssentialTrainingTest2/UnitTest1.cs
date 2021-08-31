using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining2;

namespace EssentialTrainingTest2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testInstance = new Class1();
            var testResutl = testInstance.AddTwo(9, 5);
            Assert.AreEqual(14, testResutl, "Expected answer is 14");
        }
    }
}

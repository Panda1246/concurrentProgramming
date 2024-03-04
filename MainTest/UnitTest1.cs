
using Microsoft.VisualStudio.TestPlatform.TestHost;
using conncurentPrograming;

namespace MainTest


{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(true);
            TestMath testMath = new TestMath();
            Assert.AreEqual(testMath.mathPow(2, 3), 8);
           
        }
    }
}
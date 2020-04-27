using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwitchCoverage;

namespace SwitchCoverageTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Foo foo = new Foo();
            Assert.AreEqual(1, foo.Bar("one"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Foo foo = new Foo();
            Assert.AreEqual(2, foo.Bar("two"));
        }
    }
}

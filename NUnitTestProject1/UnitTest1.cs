using NUnit.Framework;
using SwitchCoverage;

namespace NUnitTestProject1
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
            Foo foo = new Foo();
            Assert.AreEqual(3, foo.Bar("three"));
        }

        [Test]
        public void Test2()
        {
            Foo foo = new Foo();
            Assert.AreEqual(1, foo.Bar("one"));
        }
    }
}
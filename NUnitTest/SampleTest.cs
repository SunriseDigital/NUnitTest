using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;

namespace NUnitTest
{
    [TestFixture]
    public class SampleTest
    {
        [Test]
        public void TestMethod()
        {
            Assert.AreEqual("aaa", "aaa");
        }

        [Test]
        public void FailTestMethod()
        {
            Assert.AreEqual("ccc", "aaa");
        }
    }
}

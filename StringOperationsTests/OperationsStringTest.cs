using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit;
using StringOperations;

namespace StringOperationsTests
{
    [TestFixture]
    public class OperationsStringTest
    {
        [Test]
        [TestCase("pale", "ple ")]
        [TestCase("pales", "pale")]
        [TestCase("pale", "bale")]
        public void TrueTest(string a,string b)
        {
            var output = Operations.OneOrZeroEDit(a, b);
            bool expected = true;
            Assert.AreEqual(output, expected);
        }

        [Test]
        [TestCase("pale", "bake")]
        
        public void FalseTest(string a, string b)
        {
            var output = Operations.OneOrZeroEDit(a, b);
            bool expected = false;
            Assert.AreEqual(output, expected);
        }
    }
}

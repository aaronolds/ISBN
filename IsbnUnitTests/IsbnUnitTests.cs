using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Isbn.Tests
{
    [TestClass]
    public class IsbnUnitTests
    {
        [TestMethod]
        public void Isbn13ChecksumTest()
        {
            var isbn = new Isbn();
            var x = isbn.Isbn13Checksum("978817525766");
            Assert.AreEqual("5", x);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Isbn13ChecksumTestThrowsFormatException()
        {
            string s;
            var s0 = new Isbn();
            s = s0.Isbn13Checksum("000...00..0.");
        }
    }
}
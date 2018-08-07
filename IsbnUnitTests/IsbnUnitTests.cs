using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Isbn.Tests
{
    //[TestClass]
    //public class IsbnUnitTests
    //{

    //    [TestMethod]
    //    [ExpectedException(typeof(ArgumentNullException))]
    //    public void Isbn13ChecksumTestThrowsArgumentNullException626()
    //    {
    //        string s;
    //        var s0 = new IsbnValidator();
    //        s = s0.Isbn13Checksum((string)null);
    //    }

    //    [TestMethod]
    //    [ExpectedException(typeof(ArgumentException))]
    //    public void Isbn13ChecksumTestThrowsArgumentException34()
    //    {
    //        string s;
    //        var s0 = new IsbnValidator();
    //        s = s0.Isbn13Checksum("");
    //    }

    //    [TestMethod]
    //    [ExpectedException(typeof(ArgumentException))]
    //    public void Isbn13ChecksumTestThrowsArgumentException687()
    //    {
    //        string s;
    //        var s0 = new IsbnValidator();
    //        s = s0.Isbn13Checksum("\0");
    //    }

    //    [TestMethod]
    //    [ExpectedException(typeof(ArgumentException))]
    //    public void Isbn13ChecksumTestThrowsArgumentException736()
    //    {
    //        string s;
    //        var s0 = new IsbnValidator();
    //        s = s0.Isbn13Checksum("0");
    //    }

    //    [TestMethod]
    //    [ExpectedException(typeof(ArgumentException))]
    //    public void Isbn13ChecksumTestThrowsArgumentException175()
    //    {
    //        string s;
    //        var s0 = new IsbnValidator();
    //        s = s0.Isbn13Checksum("\0\0");
    //    }

    //    [TestMethod]
    //    [ExpectedException(typeof(ArgumentException))]
    //    public void Isbn13ChecksumTestThrowsArgumentException691()
    //    {
    //        string s;
    //        var s0 = new IsbnValidator();
    //        s = s0.Isbn13Checksum("\0\0\0");
    //    }

    //    [TestMethod]
    //    [ExpectedException(typeof(ArgumentException))]
    //    public void Isbn13ChecksumTestThrowsArgumentException902()
    //    {
    //        string s;
    //        var s0 = new IsbnValidator();
    //        s = s0.Isbn13Checksum("\00");
    //    }

    //    [TestMethod]
    //    [ExpectedException(typeof(ArgumentException))]
    //    public void Isbn13ChecksumTestThrowsArgumentException29()
    //    {
    //        string s;
    //        var s0 = new IsbnValidator();
    //        s = s0.Isbn13Checksum("/");
    //    }

    //    [TestMethod]
    //    [ExpectedException(typeof(ArgumentException))]
    //    public void Isbn13ChecksumTestThrowsArgumentException111()
    //    {
    //        string s;
    //        var s0 = new IsbnValidator();
    //        s = s0.Isbn13Checksum("0\0");
    //    }

    //    [TestMethod]
    //    [ExpectedException(typeof(ArgumentException))]
    //    public void Isbn13ChecksumTestThrowsArgumentException733()
    //    {
    //        string s;
    //        var s0 = new IsbnValidator();
    //        s = s0.Isbn13Checksum("00");
    //    }

    //    [TestMethod]
    //    [ExpectedException(typeof(ArgumentException))]
    //    public void Isbn13ChecksumTestThrowsArgumentException209()
    //    {
    //        string s;
    //        var s0 = new IsbnValidator();
    //        s = s0.Isbn13Checksum("00\0");
    //    }

    //    [TestMethod]
    //    [ExpectedException(typeof(ArgumentException))]
    //    public void Isbn13ChecksumTestThrowsArgumentException435()
    //    {
    //        string s;
    //        var s0 = new IsbnValidator();
    //        s = s0.Isbn13Checksum("0/0");
    //    }

    //    [TestMethod]
    //    [ExpectedException(typeof(ArgumentException))]
    //    public void Isbn13ChecksumTestThrowsArgumentException657()
    //    {
    //        string s;
    //        var s0 = new IsbnValidator();
    //        s = s0.Isbn13Checksum("0/0\0");
    //    }

    //    [TestMethod]
    //    [ExpectedException(typeof(ArgumentException))]
    //    public void Isbn13ChecksumTestThrowsFormatException712()
    //    {
    //        string s;
    //        var s0 = new IsbnValidator();
    //        s = s0.Isbn13Checksum("000...00..0.");
    //    }


    //    [TestMethod]
    //    public void Isbn13ChecksumTest()
    //    {
    //        var isbn = new IsbnValidator();
    //        var x = isbn.Isbn13Checksum("978817525766");
    //        Assert.AreEqual("5", x);
    //    }

    //    [TestMethod]
    //    [ExpectedException(typeof(ArgumentException))]
    //    public void Isbn13ChecksumTestThrowsFormatException()
    //    {
    //        string s;
    //        var s0 = new IsbnValidator();
    //        s = s0.Isbn13Checksum("000...00..0.");
    //    }
    //}
}
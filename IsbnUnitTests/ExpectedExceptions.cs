using NUnit.Framework;
using System;
using System.Collections;

namespace IsbnUnitTests
{
    [TestFixture]
    public class ExpectedExceptions
    {
        [Test]
        public void IsbnArgumnetNullExceptionTest()
        {
            var isbn = new Isbn.IsbnValidator();
            Assert.That(() => isbn.IsValid(null), Throws.Exception.TypeOf<ArgumentNullException>());
        }


        //[Test, TestCaseSource(typeof(ExpectedException_AgumentException), "TestCasesIsbn10")]
        //public void Isbn10ArgumentExceptionTest(string s, bool expectedResult)
        //{
        //    var isbn = new Isbn.IsbnValidator();
        //    Assert.That(() => isbn.IsValid(s), Throws.Exception.TypeOf<ArgumentException>());
        //}

        //[Test, TestCaseSource(typeof(ExpectedException_AgumentException), "TestCasesIsbn13")]
        //public void Isbn13ArgumentExceptionTest(string s, bool expectedResult)
        //{
        //    var isbn = new Isbn.IsbnValidator();
        //    Assert.That(() => isbn.IsValid(s), Throws.Exception.TypeOf<ArgumentException>());
        //}

        //public class ExpectedException_AgumentException
        //{
        //    public static IEnumerable TestCasesIsbn10
        //    {
        //        get
        //        {
        //            yield return new TestCaseData("+_)(*&#@!e", false);
        //            yield return new TestCaseData("\0 k 88**&(", false);
        //            yield return new TestCaseData(@"80\0\6\y\t", false);
        //            yield return new TestCaseData("          ", false);
        //            yield return new TestCaseData("0w...00...", false);
        //        }
        //    }

        //    public static IEnumerable TestCasesIsbn13
        //    {
        //        get
        //        {
        //            yield return new TestCaseData("+_)(*&^%$#@!e", false);
        //            yield return new TestCaseData("\0 k 8, 88**&(", false);
        //            yield return new TestCaseData(@"800\0\0\6\y\t", false);
        //            yield return new TestCaseData("             ", false);
        //            yield return new TestCaseData("0wr00...00...", false);
        //        }
        //    }
        //    //yield return new TestCaseData("0000000000000");  INTERESTING CASE

        //}
    }
}

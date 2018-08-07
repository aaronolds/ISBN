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


        [Test, TestCaseSource(typeof(ExpectedException_AgumentException), "TestCasesIsbn10")]
        public void Isbn10ArgumentExceptionTest(string s)
        {
            var isbn = new Isbn.IsbnValidator();
            Assert.That(() => isbn.IsValid(s), Throws.Exception.TypeOf<ArgumentException>());
        }

        [Test, TestCaseSource(typeof(ExpectedException_AgumentException), "TestCasesIsbn13")]
        public void Isbn13ArgumentExceptionTest(string s)
        {
            var isbn = new Isbn.IsbnValidator();
            Assert.That(() => isbn.IsValid(s), Throws.Exception.TypeOf<ArgumentException>());
        }

        public class ExpectedException_AgumentException
        {
            public static IEnumerable TestCasesIsbn10
            {
                get
                {
                    yield return new TestCaseData("+_)(*&#@!e");
                    yield return new TestCaseData("\0 k 88**&(");
                    yield return new TestCaseData(@"80\0\6\y\t");
                    yield return new TestCaseData("          ");
                    yield return new TestCaseData("0w...00...");
                }
            }

            public static IEnumerable TestCasesIsbn13
            {
                get
                {
                    yield return new TestCaseData("+_)(*&^%$#@!e");
                    yield return new TestCaseData("\0 k 8, 88**&(");
                    yield return new TestCaseData(@"800\0\0\6\y\t");
                    yield return new TestCaseData("             ");
                    yield return new TestCaseData("0wr00...00...");
                }
            }
            //yield return new TestCaseData("0000000000000");  INTERESTING CASE

        }
    }
}

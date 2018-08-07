using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace IsbnUnitTests
{
    [TestFixture]
    public class ExpectedIsbnFalse
    {  /// <summary>
        /// Theses the are valid isbn10 test.
        /// </summary>
        /// <param name="s">The s.</param>
        [Test, TestCaseSource(typeof(IsbnBadExamples), nameof(IsbnBadExamples.TestCasesIsbn10))]
        public void TheseAreValidIsbn10Test(string s)
        {
            var isbn = new Isbn.IsbnValidator();
            Assert.IsFalse(isbn.IsValid(s));
        }

        /// <summary>
        /// Theses the are valid isbn13 test.
        /// </summary>
        /// <param name="s">The s.</param>
        [Test, TestCaseSource(typeof(IsbnBadExamples), nameof(IsbnBadExamples.TestCasesIsbn13))]
        public void TheseAreValidIsbn13Test(string s)
        {
            var isbn = new Isbn.IsbnValidator();
            Assert.IsFalse(isbn.IsValid(s));
        }


        public class IsbnBadExamples
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
        }
    }
}

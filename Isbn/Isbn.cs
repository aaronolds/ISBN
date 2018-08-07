using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Isbn
{
    public class IsbnValidator
    {
        public bool IsValid(string isbn)
        {
            ArgumentNotNullOrEmptyString(isbn, nameof(isbn));
            var s = RemoveNonIntegers(isbn);
            if (s.Length == 10)
            {
                return IsValidIsbn10(isbn);
            }
            else if (s.Length == 13)
            {
                return IsValidIsbn13(s, out _);
            }
            return false;
        }

        private bool IsValidIsbn10(string isbn)
        {
            var s = RemoveNonIntegers(isbn);
            if (s.Length < 10) throw new ArgumentException();

            return false;
        }

        private bool IsValidIsbn13(string isbn, out string correctIsbn)
        {
            correctIsbn = isbn.Substring(0, 12) + Isbn13Checksum(isbn);

            return (correctIsbn == isbn);
        }

        private static string Isbn10Checksum(string isbn)
        {
            int sum = 0;
            for (int i = 0; i < 9; i++)
                sum += (10 - i) * Int32.Parse(isbn[i].ToString());

            float div = sum / 11;
            float rem = sum % 11;

            if (rem == 0)
                return "0";
            else if (rem == 1)
                return "X";
            else
                return (11 - rem).ToString();
        }

        private static string Isbn13Checksum(string isbn)
        {
            float sum = 0;
            for (int i = 0; i < 12; i++)
            {
                sum += ((i % 2 == 0) ? 1 : 3) * Int32.Parse(isbn[i].ToString());
            }

            float div = sum / 10;
            float rem = sum % 10;

            if (rem == 0)
                return "0";
            else
                return (10 - rem).ToString();
        }

        /// <summary>
        ///     Removes the non integers.
        /// </summary>
        /// <param name="isbn">The isbn.</param>
        /// <returns></returns>
        private static string RemoveNonIntegers(string isbn)
        {
            return Regex.Replace(isbn, "[^0-9]", "");
        }

        /// <summary>
        ///     Arguments the not null.
        /// </summary>
        /// <param name="argumentValue">The argument value.</param>
        /// <param name="argumentName">Name of the argument.</param>
        private static void ArgumentNotNull(object argumentValue, string argumentName)
        {
            if (argumentValue == null) throw new ArgumentNullException(argumentName);
        }

        /// <summary>
        ///     Arguments the not null or empty string.
        /// </summary>
        /// <param name="argumentValue">The argument value.</param>
        /// <param name="argumentName">Name of the argument.</param>
        private static void ArgumentNotNullOrEmptyString(string argumentValue, string argumentName)
        {
            ArgumentNotNull(argumentValue, argumentName);
            if (argumentValue.Length == 0) throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "String Cannot Be Empty"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Isbn
{
    public class Isbn
    {
        public string Isbn13Checksum(string isbn)
        {
            ArgumentNotNullOrEmptyString(isbn, nameof(isbn));
            var s = RemoveNonIntegers(isbn);
            if (s.Length < 12) throw new ArgumentException();

            float sum = 0;
            for (var i = 0; i < 12; i++) sum += (i % 2 == 0 ? 1 : 3) * int.Parse(s[i].ToString());

            var rem = sum % 10;

            return Math.Abs(rem) < 0 ? "0" : (10 - rem).ToString(CultureInfo.InvariantCulture);
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

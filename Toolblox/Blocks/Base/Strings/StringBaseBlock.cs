using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using Ardalis.GuardClauses;

namespace Cognophile.Toolblox.Blocks.Base.Strings
{
    public static class StringBaseBlock
    {
        #region Deterministic Members
        public static bool IsNull(string subject)
        {
            return subject is null;
        }

        public static bool IsEmpty(string subject)
        {
            Guard.Against.Null(subject, nameof(subject));

            return subject == "";
        }

        public static bool IsNullOrEmpty(string subject)
        {
            return string.IsNullOrEmpty(subject);
        }

        public static bool IsWhitespace(string subject)
        {
            Guard.Against.NullOrEmpty(subject, nameof(subject));

            return subject.All(char.IsWhiteSpace);
        }

        public static bool IsNullOrWhitespace(string subject)
        {
            return string.IsNullOrWhiteSpace(subject);
        }

        public static bool IsTitlecase(string subject)
        {
            Guard.Against.NullOrWhiteSpace(subject, nameof(subject));

            return subject == CultureInfo.CurrentCulture.TextInfo.ToTitleCase(subject);
        }

        public static bool IsCapitalised(string subject)
        {
            Guard.Against.NullOrWhiteSpace(subject, nameof(subject));

            return subject.First() == char.ToUpper(subject.First());
        }

        public static bool IsAlpha(string subject)
        {
            Guard.Against.NullOrWhiteSpace(subject, nameof(subject));

            return subject.All(char.IsLetter);
        }

        public static bool IsNumeric(string subject)
        {
            Guard.Against.NullOrWhiteSpace(subject, nameof(subject));

            return subject.All(char.IsDigit);
        }

        public static bool IsSymbols(string subject)
        {
            Guard.Against.NullOrWhiteSpace(subject, nameof(subject));

            return subject.All(i => char.IsSymbol(i) || char.IsPunctuation(i));
        }

        public static bool IsNumericSymbols(string subject)
        {
            Guard.Against.NullOrWhiteSpace(subject, nameof(subject));

            return subject.All(i => char.IsDigit(i) || char.IsSymbol(i) || char.IsPunctuation(i));
        }

        public static bool IsAlphaNumeric(string subject)
        {
            Guard.Against.NullOrWhiteSpace(subject, nameof(subject));

            return subject.All(char.IsLetterOrDigit);
        }

        public static bool IsAlphaNumericSymbols(string subject)
        {
            Guard.Against.NullOrWhiteSpace(subject, nameof(subject));

            return subject.All(i => char.IsLetterOrDigit(i) || char.IsSymbol(i) || char.IsPunctuation(i));
        }

        public static bool Matches(string subject, string pattern)
        {
            Guard.Against.NullOrWhiteSpace(subject, nameof(subject));
            Guard.Against.NullOrWhiteSpace(pattern, nameof(pattern));

            return Regex.IsMatch(subject, @$"{pattern}");
        }

        public static string AsNullWhenEmpty(string subject)
        {
            return string.IsNullOrEmpty(subject) ? null : subject;
        }

        public static string AsNullWhenWhitespace(string subject)
        {
            return string.IsNullOrWhiteSpace(subject) ? null : subject;
        }
        #endregion

        #region Fetching Members
        public static string Between(string subject, string left, string right)
        {
            Guard.Against.NullOrWhiteSpace(subject, nameof(subject));
            Guard.Against.NullOrWhiteSpace(left, nameof(left));
            Guard.Against.NullOrWhiteSpace(right, nameof(right));

            const int isFound = -1;
            int startIndex = subject.IndexOf(left);

            if (!startIndex.Equals(isFound))
            {
                startIndex += left.Length;
                int endIndex = subject.IndexOf(right, startIndex);

                if (endIndex > startIndex)
                {
                    return subject[startIndex..endIndex].Trim();
                }
            }

            return null;
        }
        #endregion

        #region Mutative Members
        public static ICollection<string> Explode(string subject, char separator)
        {
            Guard.Against.NullOrWhiteSpace(subject, nameof(subject));

            return subject.Split(separator).ToList();
        }

        public static string Implode(ICollection<string> substrings, char separator)
        {
            Guard.Against.Null(separator, nameof(separator));
            Guard.Against.Null(substrings, nameof(substrings));

            return string.Join(separator, substrings);
        }

        public static string Titlecase(string subject)
        {
            Guard.Against.NullOrWhiteSpace(subject, nameof(subject));
            if (IsTitlecase(subject)) 
            {
                return subject;
            }

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(subject);
        }

        public static string Capitalise(string subject)
        {
            Guard.Against.NullOrWhiteSpace(subject, nameof(subject));
            if (IsCapitalised(subject)) 
            {
                return subject;
            }

            return string.Concat(subject[0].ToString().ToUpper(), subject.AsSpan(1));
        }
        #endregion
    }
}
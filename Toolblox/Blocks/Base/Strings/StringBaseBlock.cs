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

            return Regex.IsMatch(subject, @"/^\s*$/");
        }

        public static bool IsNullOrWhitespace(string subject)
        {
            Guard.Against.NullOrEmpty(subject, nameof(subject));

            return string.IsNullOrWhiteSpace(subject);
        }

        public static bool IsTitlecase(string subject)
        {
            Guard.Against.NullOrWhiteSpace(subject, nameof(subject));

            return subject == CultureInfo.CurrentCulture.TextInfo.ToTitleCase(subject);
        }

        public static bool Matches(string subject, string pattern)
        {
            Guard.Against.NullOrWhiteSpace(subject, nameof(subject));
            Guard.Against.NullOrWhiteSpace(pattern, nameof(pattern));

            return Regex.IsMatch(subject, @$"{pattern}");
        }

        public static bool Contains(string haystack, string needle)
        {
            return haystack.Contains(needle);
        }
        #endregion

        #region Fetching Members
        public static string Between(string subject, string left, string right)
        {
            const int isFound = -1;
            int startIndex = subject.IndexOf(left);

            if (!startIndex.Equals(isFound))
            {
                startIndex += left.Length;

                int endIndex = subject.IndexOf(right, startIndex);
                if (endIndex > startIndex)
                {
                    return subject[startIndex..endIndex];
                }
            }

            return string.Empty;
        }
        #endregion

        #region Mutative Members
        public static ICollection<string> Explode(string subject, char[] separators)
        {
            Guard.Against.NullOrWhiteSpace(subject, nameof(subject));

            return subject.Split(separators).ToList();
        }

        public static string Implode(char separator, ICollection<string> parts)
        {
            Guard.Against.Null(separator, nameof(separator));
            Guard.Against.Null(parts, nameof(parts));

            return string.Join(separator, parts);
        }

        public static string Titlecase(string subject)
        {
            Guard.Against.NullOrWhiteSpace(subject, nameof(subject));

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(subject);
        }
        #endregion
    }
}
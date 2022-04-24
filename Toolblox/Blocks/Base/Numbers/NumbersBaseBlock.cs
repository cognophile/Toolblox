using System;
using System.Globalization;

namespace Cognophile.Toolblox.Blocks.Base.Numbers
{
    public static class NumbersBaseBlock
    {
        public static bool IsZero(int subject)
        {
            return subject.Equals(0);
        }

        public static bool IsZero(double subject)
        {
            return subject.Equals(0);
        }

        public static bool IsZero(decimal subject)
        {
            return subject.Equals(0);
        }

        public static bool IsPositive(int subject)
        {
            return subject > 0;
        }

        public static bool IsPositive(double subject)
        {
            return subject > 0;
        }

        public static bool IsPositive(decimal subject)
        {
            return subject > 0;
        }

        public static bool IsNegative(int subject)
        {
            return subject < 0;
        }

        public static bool IsNegative(double subject)
        {
            return subject < 0;
        }

        public static bool IsNegative(decimal subject)
        {
            return subject < 0;
        }

        public static bool IsLessThan(int subject, int threshold)
        {
            return threshold > subject;
        }

        public static bool IsLessThan(double subject, double threshold)
        {
            return threshold > subject;
        }

        public static bool IsLessThan(decimal subject, decimal threshold)
        {
            return threshold > subject;
        }

        public static bool IsGreaterThan(int subject, int threshold)
        {
            return threshold < subject;
        }

        public static bool IsGreaterThan(double subject, double threshold)
        {
            return threshold < subject;
        }

        public static bool IsGreaterThan(decimal subject, decimal threshold)
        {
            return threshold < subject;
        }

        public static bool IsDivisibleBy(int subject, int divisor)
        {
            return subject % divisor == 0;
        }

        public static bool IsMultipleOf(int subject, int multiplier)
        {
            return subject % multiplier == 0;
        }

        public static T ParseAs<T>(object subject)
        {
            return (T)Convert.ChangeType(subject, typeof(T));
        }

        public static string AsCurrency(int subject, string culture = null)
        {
            if (culture is null)
            {
                culture = CultureInfo.CurrentCulture.Name;
            }

            return subject.ToString("C", CultureInfo.CreateSpecificCulture(culture));
        }

        public static string AsCurrency(double subject, string culture = null)
        {
            if (culture is null)
            {
                culture = CultureInfo.CurrentCulture.Name;
            }

            return subject.ToString("C", CultureInfo.CreateSpecificCulture(culture));
        }

        public static string AsCurrency(decimal subject, string culture = null)
        {
            if (culture is null)
            {
                culture = CultureInfo.CurrentCulture.Name;
            }

            return subject.ToString("C", CultureInfo.CreateSpecificCulture(culture));
        }
    }
}

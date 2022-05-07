namespace Cognophile.Toolblox.Blocks.Base.Boolean
{
    public static class BooleanBaseBlock
    {
        /// <summary>
        /// Get a textual representation of the boolean value
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Yes or No, based upon the boolean value</returns>
        public static string ToTextual(bool subject)
        {
            return subject ? "Yes" : "No";
        }

        /// <summary>
        /// Determines if the subject is false
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean representation of the subject state</returns>
        public static bool IsFalse(bool subject)
        {
            return subject.Equals(false);
        }

        /// <summary>
        /// Determines if the subject is true
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean representation of the subject state</returns>
        public static bool IsTrue(bool subject)
        {
            return subject.Equals(true);
        }
    }
}

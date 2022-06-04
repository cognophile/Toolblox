using Cognophile.Toolblox.Blocks.Base.Boolean;

namespace Cognophile.Toolblox.Blocks.Extensions.Boolean
{
    public static class BooleanExtensionsBlock
    {
        /// <summary>
        /// Get a textual representation of the boolean value
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Yes or No, based upon the boolean value</returns>
        public static string ToTextual(this bool subject)
        {
            return BooleanBaseBlock.ToTextual(subject);
        }

        /// <summary>
        /// Determines if the subject is false
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean representation of the subject state</returns>
        public static bool IsFalse(this bool subject)
        {
            return BooleanBaseBlock.IsFalse(subject);
        }

        /// <summary>
        /// Determines if the subject is true
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean representation of the subject state</returns>
        public static bool IsTrue(this bool subject)
        {
            return BooleanBaseBlock.IsTrue(subject);
        }
    }
}

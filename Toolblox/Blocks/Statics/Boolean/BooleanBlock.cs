using Cognophile.Toolblox.Blocks.Base;
using Cognophile.Toolblox.Blocks.Base.Boolean;

namespace Cognophile.Toolblox.Blocks.Statics.Boolean
{
    public sealed class BooleanBlock : IBlock
    {
        /// <summary>
        /// Get a textual representation of the boolean value
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Yes or No, based upon the boolean value</returns>
        public static string ToTextual(bool subject)
        {
            return BooleanBaseBlock.ToTextual(subject);
        }

        /// <summary>
        /// Determines if the subject is false
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean representation of the subject state</returns>
        public static bool IsFalse(bool subject)
        {
            return BooleanBaseBlock.IsFalse(subject);
        }

        /// <summary>
        /// Determines if the subject is true
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean representation of the subject state</returns>
        public static bool IsTrue(bool subject)
        {
            return BooleanBaseBlock.IsTrue(subject);
        }
    }
}

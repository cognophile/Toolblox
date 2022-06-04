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
#pragma warning disable CA1822 // Mark members as static
        public string ToTextual(bool subject) => BooleanBaseBlock.ToTextual(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines if the subject is false
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean representation of the subject state</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsFalse(bool subject) => BooleanBaseBlock.IsFalse(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines if the subject is true
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean representation of the subject state</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsTrue(bool subject) => BooleanBaseBlock.IsTrue(subject);
#pragma warning restore CA1822 // Mark members as static
    }
}

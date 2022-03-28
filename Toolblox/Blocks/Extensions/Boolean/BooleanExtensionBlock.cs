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
    }
}

using System;
using Cognophile.Toolblox.Blocks.Base;
using Cognophile.Toolblox.Blocks.Base.Objects;

namespace Cognophile.Toolblox.Blocks.Statics.Objects
{
    public sealed class ObjectBlock : IBlock
    {
        /// <summary>
        /// Determines whether the object being called upon is null
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean representing the null-state of the called-upon reference</returns>
        public static bool IsNull(object subject)
        {
            return ObjectsBaseBlock.IsNull(subject);
        }

        /// <summary>
        /// Determines whether the object being called upon is not null
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean representing the null-state of the called-upon reference</returns>
        public static bool IsNotNull(object subject)
        {
            return ObjectsBaseBlock.IsNotNull(subject);
        }

        /// <summary>
        /// Deep clone the called-upon object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="subject"></param>
        /// <returns>Returns an instance of the specified type with identical property values</returns>
        public static T Clone<T>(T subject)
        {
            return ObjectsBaseBlock.Clone(subject);
        }
    }
}

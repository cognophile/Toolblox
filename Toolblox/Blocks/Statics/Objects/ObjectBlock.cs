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
#pragma warning disable CA1822 // Mark members as static
        public bool IsNull(object subject) => ObjectsBaseBlock.IsNull(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Determines whether the object being called upon is not null
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>Boolean representing the null-state of the called-upon reference</returns>
#pragma warning disable CA1822 // Mark members as static
        public bool IsNotNull(object subject) => ObjectsBaseBlock.IsNotNull(subject);
#pragma warning restore CA1822 // Mark members as static

        /// <summary>
        /// Deep clone the called-upon object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="subject"></param>
        /// <returns>Returns an instance of the specified type with identical property values</returns>
#pragma warning disable CA1822 // Mark members as static
        public T Clone<T>(T subject) => ObjectsBaseBlock.Clone(subject);
#pragma warning restore CA1822 // Mark members as static
    }
}

using System;
using Cognophile.Toolblox.Blocks.Extensions.Boolean;
using Cognophile.Toolblox.Blocks.Extensions.Objects;

namespace Toolblox.Blocks.Results
{
    public abstract class OperationResultBase<T>
    {
        public T Content { get; set; }
        public int? Code { get; set; }
        public bool? Success { get; set; }
        public string Message { get; set; }
        public Exception Exception { get; set; }

        public OperationResultState State
        {
            get
            {
                if (Exception.IsNotNull())
                    return OperationResultState.Exception;

                if (Success.HasValue)
                {
                    if (Success.Value.IsTrue())
                        return OperationResultState.Success;

                    if (Success.Value.IsFalse())
                        return OperationResultState.Failure;
                }

                return OperationResultState.None;
            }
        }
    }
}

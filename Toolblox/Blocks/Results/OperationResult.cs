using System;
using Cognophile.Toolblox.Blocks.Extensions.Objects;
using Toolblox.Blocks.Results;

namespace Cognophile.Toolblox.Blocks.Results
{
    public class OperationResult<T> : OperationResultBase<T>, IOperationResult<T>
    {
        public OperationResult() { }
        public OperationResult(Exception exception)
        {
            Exception = exception;
        }

        public OperationResult(bool success, int code = 0, string message = null)
        {
            Success = success;
            Code = code;
            Message = message;
        }

        public bool HasSucceeded()
        {
            return State.Equals(OperationResultState.Success);
        }

        public bool HasFailed()
        {
            return State.Equals(OperationResultState.Failure);
        }

        public bool HasCode()
        {
            return Code.HasValue;
        }

        public bool HasMessage()
        {
            return !string.IsNullOrWhiteSpace(Message);
        }

        public bool HasException()
        {
            return Exception.IsNotNull();
        }

        public bool HasContent()
        {
            return Content.IsNotNull();
        }

        public IOperationResult<T> WithSuccess()
        {
            Success = true;
            return this;
        }

        public IOperationResult<T> WithSuccess(int code = 0, string message = null)
        {
            Success = true;
            Code = code;
            Message = message;
            return this;
        }

        public IOperationResult<T> WithFailure()
        {
            Success = false;
            return this;
        }

        public IOperationResult<T> WithFailure(int code = 0, string message = null)
        {
            Success = false;
            Code = code;
            Message = message;
            return this;
        }

        public IOperationResult<T> WithContent(T content)
        {
            Content = content;
            return this;
        }

        public IOperationResult<T> WithException(Exception exception)
        {
            Exception = exception;
            return this;
        }
    }
}

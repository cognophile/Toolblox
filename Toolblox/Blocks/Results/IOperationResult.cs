using System;
namespace Toolblox.Blocks.Results
{
    public interface IOperationResult<T>
    {
        public bool HasSucceeded();
        public bool HasFailed();
        public bool HasCode();
        public bool HasMessage();
        public bool HasException();
        public bool HasContent();

        public IOperationResult<T> WithSuccess();
        public IOperationResult<T> WithSuccess(int code = 0, string message = null);
        public IOperationResult<T> WithFailure();
        public IOperationResult<T> WithFailure(int code = 0, string message = null);
        public IOperationResult<T> WithException(Exception exception);
        public IOperationResult<T> WithContent(T content);
    }
}

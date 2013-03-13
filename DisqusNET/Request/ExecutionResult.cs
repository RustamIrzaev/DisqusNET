using System;

namespace DisqusNET.Request
{
    public enum ExecutionResultError
    {
        IncorrectResponse = 9001
    }

    public class ExecutionResult<T>
    {
        public T Data { get; set; }
        public bool Success { get; set; }
        public ExecutionResultError ErrorCode { get; set; }
        public string ErrorMessage { get; set; }

        internal static ExecutionResult<T> Create(T data = default(T))
        {
            return new ExecutionResult<T>
            {
                Success = true,
                ErrorMessage = null,
                Data = data
            };
        }

        internal static ExecutionResult<T> CreateError(string errorMessage)
        {
            return new ExecutionResult<T>
            {
                Success = false,
                ErrorMessage = errorMessage,
                Data = default(T)
            };
        }

        internal static ExecutionResult<T> CreateError(ExecutionResultError errorCode, string errorMessage)
        {
            return new ExecutionResult<T>
            {
                Success = false,
                ErrorMessage = errorMessage,
                ErrorCode = errorCode,
                Data = default(T)
            };
        }

        internal static ExecutionResult<T> CreateError(Exception exception)
        {
            return new ExecutionResult<T>
            {
                Success = false,
                ErrorMessage = exception.Message
            };
        }
    }
}
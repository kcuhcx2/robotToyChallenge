using System;

namespace robotToyChallenge.Shared
{

    public class OperationResult<T>
    {
        public T Data { get; set; }

        public OperationResult(T data)
        {
            Data = data;
        }

    }
}

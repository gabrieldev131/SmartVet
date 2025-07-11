using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Domain.Base
{
    public class TResult<T>
    {
        public T? Value { get; set; }
        public ResultType Type { get; set; }
        public ICollection<Error> Errors { get; set; }
        public Boolean IsSuccess { get; set; }

        public TResult()
        {
            IsSuccess = true;
            Errors = new List<Error>();
        }
        public TResult(T value)
        {
            Value = value;
            IsSuccess = true;
            Errors = new List<Error>();
        }

        public void AddError(Error error)
        {
            Type = ResultType.BAD_REQUEST;
            Errors.Add(error);
        }

        public static TResult<T> Success(T value) => new TResult<T>
        {
            IsSuccess = true,
            Value = value
        };

        public static TResult<T> Failure(ResultType type, List<string> errorMessages)
        {
            // Convert List<string> to ICollection<Error>
            var convertedErrors = errorMessages.Select(msg => Error.FromMessage(msg)).ToList();

            return new TResult<T>
            {
                IsSuccess = false, // It's a failure
                Type = type,
                Errors = convertedErrors // Assign the converted list
            };
        }
    }
}
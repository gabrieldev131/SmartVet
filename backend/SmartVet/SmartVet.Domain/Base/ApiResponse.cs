using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SmartVet.Domain.Base
{
    public class ApiResponse
    {
        public int StatusCode { get; set; } = 200;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Uri { get; set; }
        public string Message { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public object? Body { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ICollection<Error>? Errors { get; set; }

        public ApiResponse(int statusCode, string message)
        {
            StatusCode = statusCode;
            Message = message;
        }

        public ApiResponse(int statusCode, string? uri, string message)
        {
            StatusCode = statusCode;
            Uri = uri;
            Message = message;
        }

        public ApiResponse(int statusCode, string message, object body)
        {
            StatusCode = statusCode;
            Message = message;
            Body = body;
        }

        public ApiResponse(int statusCode, string? uri, string message, object body)
        {
            StatusCode = statusCode;
            Uri = uri;
            Message = message;
            Body = body;
        }

        public ApiResponse(int statusCode, string message, ICollection<Error> errors)
        {
            StatusCode = statusCode;
            Message = message;
            Errors = errors;
        }
    }
}

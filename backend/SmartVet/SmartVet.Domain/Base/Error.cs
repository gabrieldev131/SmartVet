using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Domain.Base
{
    public class Error
    {
        public string Code { get; }
        public string _message { get; }

        public Error(string code, string message)
        {
            Code = code;
            _message = message;
        }

        public Error(String menssage)
        {
            Code = "";
            _message = menssage;
        }
        public static Error FromMessage(string message)
        {
            return new Error("GENERIC_ERROR", message); // You can use any default code
        }
    }
}

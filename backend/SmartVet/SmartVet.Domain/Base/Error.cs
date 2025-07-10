using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Domain.Base
{
    public class Error
    {
        public String _message { get; set; }

        public Error(String menssage)
        {
            _message = menssage;
        }
    }
}

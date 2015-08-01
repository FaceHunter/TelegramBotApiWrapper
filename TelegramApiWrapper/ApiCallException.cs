using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramApiWrapper
{
    class ApiCallException : Exception
    {
        public ApiCallException(string message) : base(message)
        {
        }
    }
}

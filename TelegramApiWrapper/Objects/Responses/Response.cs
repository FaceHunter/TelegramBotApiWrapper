using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramApiWrapper.Objects.Responses
{
    public class Response<T>
    {
        public bool ok;
        public T result;
        public string description;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Response<T> where T : new()
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        public Response()
        {
            Data = new T();
        }
    }
}

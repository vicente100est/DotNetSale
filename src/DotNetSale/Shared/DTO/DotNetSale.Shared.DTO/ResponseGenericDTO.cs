using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSale.Shared.DTO
{
    public class ResponseGenericDTO
    {
        public int Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

        public ResponseGenericDTO()
        {
            this.Success = 0;
        }
    }
}

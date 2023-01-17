using DotNetSale.Backend.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSale.Backend.Service
{
    public class StatusB
    {
        public List<StatusProduct> GetAllStatus()
        {
            var lstStatus = GetAllStatus();

            return lstStatus;
        }
        public async Task<StatusProduct> GetStatusByIdAsync(int id)
        {
            var status = await GetStatusByIdAsync(id);

            return status;
        }
    }
}

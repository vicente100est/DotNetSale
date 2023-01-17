using DotNetSale.Backend.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSale.Backend.Data.DAL.IService
{
    public interface IStatusService
    {
        List<StatusProduct> GetAllStatus();
        Task<StatusProduct> GetStatusByIdAsync(int id);
    }
}

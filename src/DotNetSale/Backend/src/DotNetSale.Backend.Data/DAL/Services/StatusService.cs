using DotNetSale.Backend.Data.DAL.IService;
using DotNetSale.Backend.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSale.Backend.Data.DAL.Services
{
    public class StatusService : IStatusService
    {
        public List<StatusProduct> GetAllStatus()
        {
            using (PuntoventaContext db = new PuntoventaContext())
            {
                var lstStatus = db.StatusProducts.OrderByDescending(s => s.IdStatus)
                    .ToList();

                return lstStatus;
            }
        }

        public Task<StatusProduct> GetStatusByIdAsync(int id)
        {
            using (var db = new PuntoventaContext())
            {
                var status = db.StatusProducts.FirstOrDefault(s => s.IdStatus == id);

                return Task.FromResult(status);
            }
        }
    }
}

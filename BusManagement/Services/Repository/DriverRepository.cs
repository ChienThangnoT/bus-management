using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class DriverRepository : BaseRepository<TblDriver>
    {
        public bool GetDriverStatus(string driverId)
        {

            var driver = _dbSet.FirstOrDefault(b => b.DriverId == driverId);

            if (driver != null)
            {
                return (bool)driver.IsActive;   // true hoat dong, false khong hoat dong
            }
            return false;
        }
    }
}

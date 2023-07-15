using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class BusRouteRepository :BaseRepository<TblBusRoute>
    {
        public bool GetBusRouteStatus(string routeId)
        {

            var route = _dbSet.FirstOrDefault(b => b.RoutesId == routeId);

            if (route != null)
            {
                return (bool)route.IsActive;   // true hoat dong, false khong hoat dong
            }
            return false;
        }
    }
}

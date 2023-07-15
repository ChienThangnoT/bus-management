using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class TransportUnitRepository : BaseRepository<TblTransportUnit>
    {
        public bool GetUnitStatus(string unitId)
        {

            var unit = _dbSet.FirstOrDefault(b => b.TransportUnitId == unitId);//

            if (unit != null)
            {
                return (bool)unit.IsActive;   // true hoat dong, false khong hoat dong
            }
            return false;
        }
    }
}

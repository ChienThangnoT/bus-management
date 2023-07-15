using System;
using System.Collections.Generic;

#nullable disable

namespace Services.Models
{
    public partial class TblBusRoute
    {
        public TblBusRoute()
        {
            TblBus = new HashSet<TblBu>();
        }

        public string RoutesId { get; set; }
        public string TransportUnitId { get; set; }
        public string RoutesName { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public int? EstimatedTime { get; set; }
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public bool? IsActive { get; set; }

        public virtual TblTransportUnit TransportUnit { get; set; }
        public virtual ICollection<TblBu> TblBus { get; set; }
    }
}

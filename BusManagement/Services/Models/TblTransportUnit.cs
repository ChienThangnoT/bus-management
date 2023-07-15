using System;
using System.Collections.Generic;

#nullable disable

namespace Services.Models
{
    public partial class TblTransportUnit
    {
        public TblTransportUnit()
        {
            TblBusRoutes = new HashSet<TblBusRoute>();
        }

        public string TransportUnitId { get; set; }
        public string TransportUnitName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<TblBusRoute> TblBusRoutes { get; set; }
    }
}

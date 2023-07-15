using System;
using System.Collections.Generic;

#nullable disable

namespace Services.Models
{
    public partial class TblDriver
    {
        public string DriverId { get; set; }
        public string DriverName { get; set; }
        public DateTime? Dob { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public DateTime? StartDate { get; set; }
        public decimal? Salary { get; set; }
        public string BusId { get; set; }
        public bool? IsActive { get; set; }

        public virtual TblBu Bus { get; set; }
    }
}

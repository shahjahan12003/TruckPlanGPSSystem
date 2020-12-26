using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class TruckDriverInformation : BaseEntity
    {

        [Required]
        [StringLength(50)]
        public string GPSDeviceID { get; set; }
        [Required]
        [StringLength(100)]
        public string DriverName { get; set; }
        [Required]
        [StringLength(50)]
        public string DriverLicenseNo { get; set; }
        [StringLength(50)]
        public string DriverNationalIDNo { get; set; }
        [Required]
        public DateTime BirthDate { get; set; } 
    }
}

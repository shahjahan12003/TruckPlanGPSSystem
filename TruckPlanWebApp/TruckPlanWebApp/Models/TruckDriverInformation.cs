

using System;
using System.ComponentModel.DataAnnotations;
 

namespace TruckPlanWebApp.Models
{
    public class TruckDriverInformation
    {
        public int Id { get; set; }
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

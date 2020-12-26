using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class TruckInformation : BaseEntity
    {

        [Required]
        [StringLength(50)]
        public string GPSDeviceID { get; set; }
        [StringLength(50)]
        public string EngineNo { get; set; }
        [StringLength(50)]
        public string ChesisNo { get; set; }
        [StringLength(50)]
        public string ModelNo { get; set; }
        [Required]
        [StringLength(50)]
        public string TruckLicenseNo { get; set; } 
   
    }
}

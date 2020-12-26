 
using System.ComponentModel.DataAnnotations;
 

namespace TruckPlanWebApp.Models
{
    public class TruckInformation 
    {
        public int Id { get; set; }
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

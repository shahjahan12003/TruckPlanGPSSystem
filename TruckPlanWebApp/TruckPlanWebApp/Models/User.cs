 
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TruckPlanWebApp.Models
{
    public class User  
    {
        public User()
        {
            IsActive = true;
        }
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }
        public int Age { get; set; }
        public string GPSDeviceID { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset? LastLoginDate { get; set; }

        public ICollection<GPSTruckRecord> PostGPSTruckRecords { get; set; }
    }

    
   
}

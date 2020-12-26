 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TruckPlanWebApp.Models
{
    public class GPSTruckRecord  
    {

        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string GPSDeviceID { get; set; }
        [Required]
        public DateTime RecordDate { get; set; }
        [Required]
        public double Longitude { get; set; }
        public int UserId { get; set; }
        [Required]
        public double Latitude { get; set; }
        [StringLength(100)]
        public string CountryName { get; set; }
        public double Kilometer { get; set; }
        [DefaultValue(false)]
        public bool ProcessStatus { get; set; }
        public User CurrentUser { get; set; }


    } 
    
}

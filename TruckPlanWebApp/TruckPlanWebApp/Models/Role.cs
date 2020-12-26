 
using System.ComponentModel.DataAnnotations;

namespace TruckPlanWebApp.Models
{
    public class Role  
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
    }

   
}

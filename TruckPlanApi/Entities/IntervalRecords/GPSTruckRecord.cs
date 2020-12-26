using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class GPSTruckRecord : BaseEntity<Guid>
    {

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


   

    public class GPSTruckRecordConfiguration : IEntityTypeConfiguration<GPSTruckRecord>
    {
        public void Configure(EntityTypeBuilder<GPSTruckRecord> builder)
        {
            builder.Property(p => p.GPSDeviceID).IsRequired().HasMaxLength(50);
            builder.HasOne(p => p.CurrentUser).WithMany(c => c.PostGPSTruckRecords).HasForeignKey(p => p.UserId);
        }
    }
}

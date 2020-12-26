using AutoMapper;
using Entities;
using System;
using WebFramework.Api;

namespace TruckPlanApi.Models
{
    public class GPSTruckRecordDto : BaseDto<GPSTruckRecordDto, GPSTruckRecord, Guid>
    {
        public string GPSDeviceID { get; set; }
      
        public DateTime RecordDate { get; set; }
   
        public double Longitude { get; set; }
        public int UserId { get; set; }
    
        public double Latitude { get; set; }
    
        public string CountryName { get; set; }
        public double Kilometer { get; set; }
      
        public bool ProcessStatus { get; set; }


 
    }

    public class GPSTruckRecordSelectDto : BaseDto<GPSTruckRecordSelectDto, GPSTruckRecord, Guid>
    {
   
        public string GPSDeviceID { get; set; }
        public DateTime RecordDate { get; set; }
        public double Latitude { get; set; }
        public double Longitude{ get; set; }
        
        //public string AuthorFullName { get; set; } //=> Author.FullName
        public string CountryName { get; set; } // => Get from GPS coordinate
        public double Kilometer { get; set; }

        public override void CustomMappings(IMappingExpression<GPSTruckRecord, GPSTruckRecordSelectDto> mappingExpression)
        {
            mappingExpression.ForMember(
                    dest => dest.GPSDeviceID,
                    config => config.MapFrom(src => $"{src.GPSDeviceID} ({src.GPSDeviceID})"));
        }
    }
}

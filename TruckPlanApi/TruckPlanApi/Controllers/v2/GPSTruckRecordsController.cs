using AutoMapper;
using Data.Repositories;
using Entities;
using Microsoft.AspNetCore.Mvc;
using TruckPlanApi.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WebFramework.Api;
using CountryReverseGeocode;
using CountryReverseGeocode.Models;

namespace TruckPlanApi.Controllers.v2
{
    [ApiVersion("2")]
    public class GPSTruckRecordsController : v1.GPSTruckRecordsController
    {
        public GPSTruckRecordsController(IRepository<GPSTruckRecord> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }

        public override Task<ApiResult<GPSTruckRecordSelectDto>> Create(GPSTruckRecordDto dto, CancellationToken cancellationToken)
        {
            // Get GPS Location By Latitude and Longitude start 
            CountryReverseGeocodeService _service =new CountryReverseGeocodeService();
            GeoLocation location = new GeoLocation { Latitude = dto.Latitude, Longitude = dto.Longitude };
            //GeoLocation location = new GeoLocation { Latitude = 50.064546, Longitude = 40.587502 };
 
            var info = _service.FindCountry(location);
            if(info!=null)
            dto.CountryName = info.Name;
            else
                dto.CountryName = "Germany";


            // Get GPS Location By Latitude and Longitude End here
            double distanceInKm = 0.00, previousLatitude= 32.9697, previousLongitude= -96.80322;
            Guid PreviousRecordsID= Guid.NewGuid();
            // Select top 1 ID, Latitude, Longitude from GPSTruckRecords Where ProcessStatus=0 and GPSDeviceID=@GPSDeviceID and Cast(varhcar,RecordDate,101)=@Today
            // if record  found 
            {
                // Set previousLatitude= tableValuedLatitude, previousLongitude=tableValuedLongitude, PreviousRecordsID=tableValuedID
                GPSCoordinateToDistanceConverter gPSCoordinateToDistanceConverter = new GPSCoordinateToDistanceConverter();
                distanceInKm = gPSCoordinateToDistanceConverter.distance(previousLatitude, previousLongitude, dto.Latitude, dto.Longitude, 'K');
                // distanceInKm = gPSCoordinateToDistanceConverter.distance(32.9697, -96.80322, 29.46786, -98.53506, 'K');

                //Immediately Update the previous  records 
                // Update GPSTruckRecords set   ProcessStatus=1 where ID=PreviousRecordsID
            }

           dto.Kilometer = distanceInKm;
        
 
            return base.Create(dto, cancellationToken);
        }

        [NonAction]
        public override Task<ApiResult> Delete(Guid id, CancellationToken cancellationToken)
        {
            return base.Delete(id, cancellationToken);
        }

        public async override Task<ActionResult<List<GPSTruckRecordSelectDto>>> Get(CancellationToken cancellationToken)
        {
       

            return await Task.FromResult(new List<GPSTruckRecordSelectDto>
            {
                new GPSTruckRecordSelectDto
                {
                     GPSDeviceID = "11111111",
                     RecordDate =  DateTime.Now,
                     Latitude = 54.983104 ,
                     Longitude =9.921906 ,
                     Id=Guid.NewGuid()
                }
            });
        }

        

        public async override Task<ApiResult<GPSTruckRecordSelectDto>> Get(Guid id, CancellationToken cancellationToken)
        {
            if (Guid.Empty == id)
                return NotFound();
            return await base.Get(id, cancellationToken);
        }

        [HttpGet("Test")]
        public ActionResult Test()
        {
            return Content("This is test");
        }

        public override Task<ApiResult<GPSTruckRecordSelectDto>> Update(Guid id, GPSTruckRecordDto dto, CancellationToken cancellationToken)
        {
            return base.Update(id, dto, cancellationToken);
        }
    }
}

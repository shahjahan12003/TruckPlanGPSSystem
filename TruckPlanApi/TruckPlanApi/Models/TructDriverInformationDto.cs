using Entities;
using System;
using WebFramework.Api;

namespace TruckPlanApi.Models
{
    public class TruckDriverInformationDto : BaseDto<TruckDriverInformationDto, TruckDriverInformation>
    {
        public string GPSDeviceID { get; set; }
        public string DriverName { get; set; }
        public string DriverLicenseNo { get; set; }
        public string DriverNationalIDNo { get; set; }
        public DateTime BirthDate { get; set; }
    }
}


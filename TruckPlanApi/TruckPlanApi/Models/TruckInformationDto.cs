using Entities;
using WebFramework.Api;

namespace TruckPlanApi.Models
{
    public class TruckInformationDto : BaseDto<TruckInformationDto, TruckInformation>
    {
        public string GPSDeviceID { get; set; }
        public string EngineNo { get; set; }
        public string ChesisNo { get; set; }
        public string ModelNo { get; set; }
        public string TruckLicenseNo { get; set; }


       
    }
}


using AutoMapper;
using Data.Repositories;
using Entities;
using TruckPlanApi.Models;
using WebFramework.Api;

namespace TruckPlanApi.Controllers.v1
{
   
    public class TruckInformationsController : CrudController<TruckInformationDto, TruckInformation>
    {
        public TruckInformationsController(IRepository<TruckInformation> repository, IMapper mapper)
           : base(repository, mapper)
        {
        }
    }
}
 
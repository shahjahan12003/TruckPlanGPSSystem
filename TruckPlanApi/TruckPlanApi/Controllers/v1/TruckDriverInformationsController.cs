using AutoMapper;
using Data.Repositories;
using Entities;
using TruckPlanApi.Models;
using WebFramework.Api;
namespace TruckPlanApi.Controllers.v1
{
     public class TruckDriverInformationsController : CrudController<TruckDriverInformationDto, TruckDriverInformation>
    {
        public TruckDriverInformationsController(IRepository<TruckDriverInformation> repository, IMapper mapper)
           : base(repository, mapper)
        {
        }
    }
}
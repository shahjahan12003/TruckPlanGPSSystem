using AutoMapper;
using Data.Repositories;
using Entities;
using TruckPlanApi.Models;
using System;
using WebFramework.Api;

namespace TruckPlanApi.Controllers.v1
{
    public class GPSTruckRecordsController : CrudController<GPSTruckRecordDto, GPSTruckRecordSelectDto, GPSTruckRecord, Guid>
    {
        public GPSTruckRecordsController(IRepository<GPSTruckRecord> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
 
    }
}

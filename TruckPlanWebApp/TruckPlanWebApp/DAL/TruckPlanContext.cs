using TruckPlanWebApp.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TruckPlanWebApp.DAL
{
    public class TruckPlanContext : DbContext
    {
        public DbSet<GPSTruckRecord> GPSTruckRecords { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<TruckDriverInformation> TruckDriverInformations { get; set; }
        public DbSet<TruckInformation> TruckInformations { get; set; }
        public DbSet<User> Users { get; set; }
       
       
    }
}
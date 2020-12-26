using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace TruckPlanWebApp.DAL
{
    public class TruckPlanConfiguration : DbConfiguration
    {
        public TruckPlanConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
        }
    }
}
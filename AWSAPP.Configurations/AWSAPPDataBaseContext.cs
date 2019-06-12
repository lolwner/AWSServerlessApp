using AWSAPP.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace AWSAPP.Configurations
{
    public class AWSAPPDataBaseContext : DbContext
    {
        public AWSAPPDataBaseContext(DbContextOptions<AWSAPPDataBaseContext> options) : base(options)
        {
        }

        public DbSet<Acquaintance> Acquaintances { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}

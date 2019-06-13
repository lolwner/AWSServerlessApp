using AWSAPP.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace AWSAPP.DataAccess
{
    public class DataBaseContextConfiguration : DbContext
    {
        public DataBaseContextConfiguration(DbContextOptions<DataBaseContextConfiguration> options) : base(options)
        {
        }

        public DbSet<Acquaintance> Acquaintances { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}

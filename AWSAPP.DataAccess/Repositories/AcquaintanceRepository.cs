using AWSAPP.Configurations;
using AWSAPP.DataAccess.Repositories.Interfaces;
using AWSAPP.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSAPP.DataAccess.Repositories
{
    public class AcquaintanceRepository : BaseRepository<Acquaintance>, IAcquaintanceRepository
    {
        public AcquaintanceRepository(DataBaseContextConfiguration context) : base(context)
        {
        }

        public async Task<List<Acquaintance>> GetAcquaintancesByClientId()
        {
            List<Acquaintance> acquaintances = await _dbSet
                .Where(ac => ac.ClientId == 10064)
                .ToListAsync();
            return acquaintances;
        }
    }
}

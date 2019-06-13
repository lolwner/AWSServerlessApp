using AWSAPP.DataAccess.Repositories.Interfaces;
using AWSAPP.Services.Services.Interfaces;
using AWSAPP.ViewModels.AcquaintanceViews;
using System.Threading.Tasks;

namespace AWSAPP.Services.Services
{
    public class AcquaintanceService : IAcquaintanceService
    {
        private readonly IAcquaintanceRepository _acquaintanceRepository;

        public AcquaintanceService(IAcquaintanceRepository acquaintanceRepository)
        {
            _acquaintanceRepository = acquaintanceRepository;
        }

        public async Task<AcquaintanceViewModel> GetAcquaintanceAsync()
        {
            var res = await _acquaintanceRepository.FindById(10026);
            var model = new AcquaintanceViewModel()
            {
                Name = res.Name,
                DateOfBirth = res.DateOfBirth,
                RelationNote = res.RelationNote
                
            };
            return model;
        }
    }
}

using AWSAPP.ViewModels.AcquaintanceViews;
using System.Threading.Tasks;

namespace AWSAPP.Services.Services.Interfaces
{
    public interface IAcquaintanceService
    {
        Task<AcquaintanceViewModel> GetAcquaintanceAsync();
    }
}

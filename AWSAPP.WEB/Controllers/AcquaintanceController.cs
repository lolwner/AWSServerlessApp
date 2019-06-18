using AWSAPP.Services.Services.Interfaces;
using AWSAPP.ViewModels.AcquaintanceViews;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AWSAPP.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcquaintanceController : ControllerBase
    {
        private readonly IAcquaintanceService _acquaintanceService;

        public AcquaintanceController(IAcquaintanceService acquaintanceService)
        {
            _acquaintanceService = acquaintanceService;
        }

        [HttpGet]
        public async Task<AcquaintanceViewModel> GetAsync()
        {
            var testResult = await  _acquaintanceService.GetAcquaintanceAsync();
            return testResult;
        }
    }
}
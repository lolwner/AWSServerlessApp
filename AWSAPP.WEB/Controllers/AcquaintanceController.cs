﻿using AWSAPP.Configuration;
using AWSAPP.Services.Services.Interfaces;
using AWSAPP.ViewModels.AcquaintanceViews;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AWSAPP.WEB.Controllers
{
    [ApiController]
    public class AcquaintanceController : ControllerBase
    {
        private readonly IAcquaintanceService _acquaintanceService;

        public AcquaintanceController(IAcquaintanceService acquaintanceService)
        {
            _acquaintanceService = acquaintanceService;
        }

        [HttpGet("api/[controller]/GetAcquaintance")]
        public async Task<AcquaintanceViewModel> GetAsync()
        {
            var testResult = await  _acquaintanceService.GetAcquaintanceAsync();
            return testResult;
        }

        [HttpGet("api/GetEnvironment")]
        public string GetEnvironment()
        {
            return EnvironmentalVariable.LambdaVariable;
        }
    }
}
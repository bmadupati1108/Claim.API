using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InsuranceClaims.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace InsuranceClaims.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClaimsController : ControllerBase
    {
        private IClaimService _claimService;

        public ClaimsController(IClaimService claimService)
        {
            _claimService = claimService;
        }


        [HttpGet("GetMemberClaimsTillDate")]
        public async Task<IActionResult> GetMemberClaimsTillDate(DateTime dateTime)
        {

            return Ok(await _claimService.GetMemberClaims(dateTime));
        }
    }
}

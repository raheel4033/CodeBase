using CodeBase.IServices;
using CodeBase.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeBase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrivacyPolicyController : ControllerBase
    {
        private readonly IPrivacyPolicyService _privacyPolicyService;
        public PrivacyPolicyController(IPrivacyPolicyService privacyPolicyService)
        {
                _privacyPolicyService = privacyPolicyService;
        }
        [HttpPost]
        [Route("postbool")]
        public async Task<IActionResult> AcceptAggrement(PrivacyPolicy privacyPolicy)
        {
            if (privacyPolicy.AgreeToTermsAndConditions)
            {
                await _privacyPolicyService.AcceptAggrementService(privacyPolicy);
                return Ok("Return Accepted");
            }
            else
            {
                return BadRequest();
            }
        }

    }
}

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Profile.Services;

namespace Profile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileService _profileService;

        public ProfileController(IProfileService profileService)
        {
            _profileService = profileService;
        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<CV.Contracts.Profile.Profile>> Get()
        {
            var profile = await _profileService.GetProfile();

            if (profile == null)
            {
                return NotFound();
            }

            return profile;
        }
    }
}

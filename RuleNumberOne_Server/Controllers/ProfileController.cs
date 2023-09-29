using Logic.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Entities.FinalModels.Profile;

namespace RuleNumberOne_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProfileController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Profile_Final>>GetProfile(string id)
        {
            Profile_Final profile = await _unitOfWork.GetProfileData(id);
            if(profile == null) return NotFound();

            return Ok(profile); 

        }

    }
}

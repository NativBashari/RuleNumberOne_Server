using Entities.EOM;
using Logic.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RuleNumberOne_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EOMController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public EOMController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IList<EOM>>> GetEndOfMonth(string id)
        {
            List<EOM> eomData = await _unitOfWork.GetEOM(id);
            if (eomData == null) return NotFound();
            return Ok(eomData);
        }
    }
}

using Entities.FinalModels.Fundamentals;
using Logic.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RuleNumberOne_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FundamentalsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public FundamentalsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FinancialData_Final>> GetFundamentalsAsync(string id)
        {
            FinancialData_Final financialData_Final =  await _unitOfWork.GetFinancialSummury(id);
            if (financialData_Final == null) return NotFound();
            return Ok(financialData_Final);
        }

    }
}

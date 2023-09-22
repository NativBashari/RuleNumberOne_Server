using Logic.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RuleNumberOne_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FundamentalsController : ControllerBase
    {
        
        public FundamentalsController(IFundamentalsLogic)
        {

        }


        [HttpGet("{id}")]
        public async Task<string> GetFundamentalsAsync(string id)
        {

        }

    }
}

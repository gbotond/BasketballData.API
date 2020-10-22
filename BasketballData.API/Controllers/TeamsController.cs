using BasketballData.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BasketballData.API.Controllers
{
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly IBasketballDataRepository _basketballDataRepository;
        
        public TeamsController(IBasketballDataRepository basketballDataRepository)
        {
            _basketballDataRepository = basketballDataRepository ?? throw new ArgumentNullException(nameof(basketballDataRepository));
        }
        
        [HttpGet("api/teams")]
        public IActionResult GetTeams()
        {
            var teamsFromRepo = _basketballDataRepository.GetTeams();

            return new JsonResult(teamsFromRepo);
        }
    }
}

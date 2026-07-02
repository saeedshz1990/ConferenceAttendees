using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConferenceAttendees.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController(IConfiguration configuration) : ControllerBase
    {
        private readonly IConfiguration _configuration = configuration;

        [HttpGet]
        public async Task<string> Get()
        {
            return _configuration["EnvironmentValue"];
        }
    }
}

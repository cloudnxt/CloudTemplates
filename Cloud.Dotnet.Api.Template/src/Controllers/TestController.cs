using Dapr.Client;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Cloud.Dotnet.Api.Template.AppSettings;
using Cloud.Dotnet.Api.Template.Models;

namespace Cloud.Dotnet.Api.Template.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;
        private readonly DaprClient _daprClient;
        private readonly IOptions<AuthSettings> _authSettings;

        public TestController(ILogger<TestController> logger, DaprClient daprClient, IOptions<AuthSettings> authSettings)
        {
            _logger = logger;
            _daprClient = daprClient;
            _authSettings = authSettings;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            _logger.LogInformation("GetAll");
            return Ok(true);
        }

        [Route("video")]
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] string key)
        {
            _logger.LogInformation($"Get{key}");
            return Ok(true);
        }
        
        [Route("video")]
        [HttpPost]
        public async Task<IActionResult> Post([FromForm] RequestModel request)
        {
            _logger.LogInformation($"Post{request.Secret}");
            return Ok(request);
        }
    }


}
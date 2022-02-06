using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesterApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TesterController : ControllerBase
    {
        private readonly ILogger<TesterController> _logger;

        public TesterController(ILogger<TesterController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Manual", "Automation", "Performance" };
        }
    }
}

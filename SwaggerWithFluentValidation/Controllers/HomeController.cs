using System.Net;
using Microsoft.AspNetCore.Mvc;
using SwaggerWithFluentValidation.Models;

namespace SwaggerWithFluentValidation.Controllers
{
    [Route("api/home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        /// <summary>
        /// Retrieves test data
        /// </summary>
        /// <returns>Test data</returns>
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(HomeViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(HomeViewModel), (int)HttpStatusCode.NotFound)]
        public IActionResult Get()
        {
            var model = new HomeViewModel();
            return Ok(model);
        }

        /// <summary>
        /// Retrieves test data
        /// </summary>
        /// <returns>Test data</returns>
        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(typeof(HomeViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(HomeViewModel), (int)HttpStatusCode.NotFound)]
        public IActionResult Post([FromBody]HomeViewModel model)
        {
            return Ok(model);
        }
    }
}

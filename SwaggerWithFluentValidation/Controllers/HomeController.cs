using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwaggerWithFluentValidation.Models;

namespace SwaggerWithFluentValidation.Controllers
{
    [Route("api/home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        /// <summary>
        ///     Retrieves test data.
        /// </summary>
        /// <returns>Test data.</returns>
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(HomeViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(HomeViewModel), (int)HttpStatusCode.NotFound)]
        public async Task<ActionResult<HomeViewModel>> Get()
        {
            var model = new HomeViewModel();
            return Ok(await Task.FromResult(model).ConfigureAwait(false));
        }

        /// <summary>
        ///     Retrieves test data.
        /// </summary>
        /// <returns>Test data.</returns>
        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(typeof(HomeViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(HomeViewModel), (int)HttpStatusCode.NotFound)]
        public async Task<ActionResult> Post([FromBody]HomeViewModel model)
        {
            return Ok(await Task.FromResult(model).ConfigureAwait(false));
        }
    }
}
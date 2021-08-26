using Inventory.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ResultController : ControllerBase
    {
        private readonly IResultService _resultService;
        public ResultController(IResultService resultService)

        {
            _resultService = resultService;
        }

        [HttpGet("results")]
        public IActionResult GetInventory()
        {
            try
            {
                var results = _resultService.GetResults();
                return Ok(results);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
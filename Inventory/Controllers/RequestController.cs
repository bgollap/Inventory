using Inventory.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Api.Controllers
{
    [Route("[controller]")]
    [Controller]
    public class RequestController : ControllerBase
    {
        private readonly IRequestService _requestService;
        public RequestController(
            IRequestService requestService
                     )
        {
            _requestService = requestService;
        }

        [HttpGet("GetRequests")]
        public IActionResult GetRequests()
        {
            try
            {
                var requests = _requestService.GetRequests();
                return Ok(requests);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}

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
       public class InventoryController : ControllerBase
    {
        private readonly IInventoryService _inventoryService;
        public InventoryController(
            IInventoryService inventoryService
                     )
        {
            _inventoryService = inventoryService;
        }

        [HttpGet("GetInventory")]
        public IActionResult GetInventory()
        {
            try
            {
                var inventories = _inventoryService.GetInventories();
                return Ok(inventories);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}

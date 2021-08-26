using System;
using System.Collections.Generic;
using System.Text;
using Inventory.Models;

namespace Inventory.Core.Services
{
    public interface IInventoryService
    {
        IEnumerable<Inventory.Models.Inventory> GetInventories();
    }
}

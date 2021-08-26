using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Core.Services
{
    public interface IRequestService
    {
        IEnumerable<Inventory.Models.Request> GetRequests();
    }
}

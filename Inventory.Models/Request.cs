using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Models
{
    public class Request
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("inventoryId")]
        public int inventoryId { get; set; }

        [JsonProperty("requestedKernels")]
        public int requestedKernels { get; set; }
    }
}

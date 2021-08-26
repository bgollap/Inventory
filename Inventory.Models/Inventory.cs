using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Models
{
  public class Inventory
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("kernels")]
        public int kernels { get; set; }
    }
}

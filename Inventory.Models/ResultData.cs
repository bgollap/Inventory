using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Models
{
  public  class ResultData
    {
        [JsonProperty("inventory")]
        public List<Inventory> inventory { get; set; }
        [JsonProperty("requests")]
        public List<Request> requests { get; set; }
    }
}

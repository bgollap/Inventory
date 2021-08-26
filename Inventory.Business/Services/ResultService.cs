using Inventory.Core.Services;
using Inventory.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace Inventory.Business.Services
{
    public class ResultService : IResultService
    {
        public ResultData GetResults()
        {
            HttpClient http = new HttpClient();
            var data = http.GetAsync("https://mocki.io/v1/0077e191-c3ae-47f6-bbbd-3b3b905e4a60").Result.Content.ReadAsStringAsync().Result.ToString();
            var res = JsonSerializer.Deserialize<Models.ResultData>(data);
            return res;
        }
    }
}

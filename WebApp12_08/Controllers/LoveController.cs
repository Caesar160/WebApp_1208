using EFDataApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using WebApp12_08.Models;
using Newtonsoft.Json;

namespace WebApp12_08.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoveController : ControllerBase {
       
        [HttpPost]
        public async Task<LoveUnit> GetLoveAsync(string fname, string sname)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://love-calculator.p.rapidapi.com/getPercentage?sname={sname}&fname={fname}"),
                Headers =
    {
        { "x-rapidapi-key", "764cab67b7mshff32de9319b1a33p1784dbjsn649a47d293bb" },
        { "x-rapidapi-host", "love-calculator.p.rapidapi.com" },
    },
            };
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<LoveUnit>(body);

        }
    }
}
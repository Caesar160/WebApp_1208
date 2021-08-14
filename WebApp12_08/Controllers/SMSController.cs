using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;


namespace WebApp12_08.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SMSController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> SendSMS(string phoneNumber, string textSMS)
        {
            var accountSid = "AC3b5c09dc83f3fd176e005d805e0d8bdb";
            var authToken = "870dd16fec4b1eaa79a1935638a842c8";
            TwilioClient.Init(accountSid, authToken);
            var message = MessageResource.Create(
                    body: textSMS,
                    from: new Twilio.Types.PhoneNumber("+16027370257"),
                    to: new Twilio.Types.PhoneNumber(phoneNumber)
                );
            return Ok();
        }
    }
}
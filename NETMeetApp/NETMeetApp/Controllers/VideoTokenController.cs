using Microsoft.AspNetCore.Mvc;
using Twilio.Jwt.AccessToken;
using dotenv.net;


namespace NETMeetApp.Controllers
{
    [ApiController]
    [Route("video-token")]
    public class VideoTokenController : ControllerBase
    {
        [HttpPost]
        public IActionResult GenerateToken([FromBody] TokenRequest request)
        {
            var accountSid = Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID");
            var apiKeySid = Environment.GetEnvironmentVariable("TWILIO_API_KEY_SID");
            var apiKeySecret = Environment.GetEnvironmentVariable("TWILIO_API_KEY_SECRET");
            

            var identity = request.Identity;

            var grant = new VideoGrant();
            var grants = new HashSet<IGrant> { grant };

            var token = new Token(
                accountSid,
                apiKeySid,
                apiKeySecret,
                identity,
                grants: grants
            );

            return Ok(new { token = token.ToJwt() });
        }

        public class TokenRequest
        {
            public string Identity { get; set; }
        }
    }
}

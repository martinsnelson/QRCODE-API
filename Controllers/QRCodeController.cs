using Microsoft.AspNetCore.Mvc;
using Shared.Services;

namespace QRCodeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QRCodeGenController : ControllerBase
    {
        [HttpGet("QRCodeFromURL/{url}")]
        public IActionResult GetQRCodeFromURL([FromServices] IQRCodeGen qrcodegen, string url)
        {
            var image = qrcodegen.GenerateByteArray(url);
            return File(image, "image/jpg");
        }

    }
}
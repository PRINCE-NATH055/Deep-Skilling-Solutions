using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class TokenValidationController : ControllerBase
{
    [HttpGet("check")]
    [Authorize]
    public IActionResult CheckTokenValidity()
    {
        return Ok("Token is valid and not expired.");
    }
}

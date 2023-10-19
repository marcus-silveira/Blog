using Blog.Data;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers;

// Health Ckech
[ApiController]
[Route("")]
public class HomeController : ControllerBase
{
    [HttpGet("")]
    public IActionResult Get([FromServices] BlogDataContext blogDataContext)
    {
        var categories = blogDataContext.Users.ToList();
        return Ok(categories);
    }
}
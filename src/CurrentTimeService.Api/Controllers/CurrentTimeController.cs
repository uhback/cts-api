using Microsoft.AspNetCore.Mvc;

namespace CurrentTimeService.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CurrentTimeController : ControllerBase
{
    [HttpGet]
    public ActionResult Get()
    {
        return Ok(new { CurrentTime = DateTime.Now });
    }
}

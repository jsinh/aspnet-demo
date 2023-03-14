using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_demo.Controllers;

public class HealthController : Controller
{
    [AllowAnonymous, HttpGet]
    public IActionResult Ping()
    {
        return Ok(new { Tick = DateTime.UnixEpoch });
    }
}
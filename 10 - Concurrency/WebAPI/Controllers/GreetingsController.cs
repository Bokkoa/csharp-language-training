using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;
[Route("api/greetings")]
public class GreetingsController : ControllerBase
{
    [HttpGet("{name}")]
    public ActionResult<string> GetGreeting(string name)
    {
        return $"Hello , {name}";
    }
}

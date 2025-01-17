using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Helpers;

namespace WebAPI.Controllers;
[Route("api/cards")]
[ApiController]
public class CardsController : ControllerBase
{

    [HttpPost]
    public async Task<ActionResult> ProcessCard([FromBody] string card)
    {
        var randomValue = RandomGenerator.NextDouble();
        var approved = randomValue > 0.1;

        await Task.Delay(100);

        Console.WriteLine($"Card {card} processed");
        return Ok(new { Card = card, Approved = approved });
    }
}
